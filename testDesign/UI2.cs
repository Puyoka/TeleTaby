using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testDesign
{
    public partial class UI2 : Form
    {
        public UI2()
        {
            InitializeComponent();
        }



        public int keszCount = 0;
        private void UI2_Load(object sender, EventArgs e)
        {
            CultureInfo ci = new CultureInfo("hu-HU");
            labelNap.Text = DateTime.Now.ToString("dddd", ci).ToUpper();
            labelIdo.Text = DateTime.Now.ToString("HH:mm:ss");

            lekerdezRendelesek(mitKerdezLe);
            keszCount = keszCounter();
            labelCounter.Text = $"{keszCount}";
            label3.Width = this.Width;

            

            timerIdo.Start();
            timerLekerdez.Start();
        }


        //!!lekérdezéshes megpróbálni listával hogy sorba legyen
        private void ButtonKesz_Click(object sender, EventArgs e)
        {
            if (dataGridViewRendelesek.Rows.Count > 0)
            {
                using (var teletabyDB = new DataContext(belepes.connectionString))
                {
                    var row = dataGridViewRendelesek.Rows[dataGridViewRendelesek.SelectedRows[0].Index];
                    teletabyDB.ExecuteCommand($"UPDATE TOP(1) rendelés_tételek SET státusz='true' WHERE rendelésID = '{row.Cells[0].Value}' AND termékID = (SELECT ID FROM termék WHERE név = '{row.Cells[2].Value}') AND megjegyzés ='{row.Cells[3].Value}'   AND státusz = '0'");
                }
                dataGridViewRendelesek.Rows.RemoveAt(dataGridViewRendelesek.SelectedRows[0].Index);
                //colors.RemoveAt(dataGridViewRendelesek.SelectedRows[0].Index);

                keszCount++;
                labelCounter.Text = $"{keszCount}";
                rowColoring(dataGridViewRendelesek);
                rowSelect();
            }
        }

       
        bool mitKerdezLe = true;
        private void ButtonElozmeny_rendeles_Click(object sender, EventArgs e)
        {
            mitKerdezLe = !mitKerdezLe;
            if (mitKerdezLe == true)
            {
                label3.Text = "Rendelések";
            }
            else
            {
                label3.Text = "Előzmények";
            }
            lekerdezRendelesek(mitKerdezLe);
            buttonKesz.Visible = !buttonKesz.Visible;
        }       
        



        static int keszCounter()
        {
            using (var teletabyDB = new DataContext(belepes.connectionString))
            {
                var table1 = teletabyDB.GetTable<Rendelés_tételek>();
                var table2 = teletabyDB.GetTable<Termék>();

                var result = (from t1 in table1
                              join t2 in table2
                              on t1.termékID equals t2.ID
                              where (t2.felhaszID == belepes.felhaszID && t1.státusz == true)
                              select t1.sorsz).Count();
                return result;
            }
        }
        
        #region rowColoring
        public Color currColor = Color.White;
        List<Color> colors = new List<Color>() { Color.White };

        private void rowColoring(DataGridView dgv)//Sárga kezdés??
        {
            int currID;
            int prevID;
            currColor = colors[0];

            for (int i = 0; i < dgv.Rows.Count ; i++)
            {
                currID = Convert.ToInt32(dgv.Rows[i].Cells[0].Value);
                if (i == 0)
                {
                    prevID = currID;
                }
                else
                {
                    prevID = Convert.ToInt32(dgv.Rows[i - 1].Cells[0].Value);
                }


                if (!currID.Equals(prevID))
                {
                    colorSwap();
                }
                dgv.Rows[i].DefaultCellStyle.BackColor = currColor;
                colors.Add(currColor);
            }
        }
        private void colorSwap()
        {
            if (currColor == Color.White)
            {
                currColor = Color.Yellow;
            }
            else
            {
                currColor = Color.White;
            }
        }
        #endregion

        
        BindingList<LekérdezésHelper> rendelesek = new BindingList<LekérdezésHelper>();        
        private void lekerdezRendelesek(bool b)
        {
            rendelesek.Clear();
            using (var teletabyDB = new DataContext(belepes.connectionString))
            {
                var table1 = teletabyDB.GetTable<Rendelés_tételek>();
                var table2 = teletabyDB.GetTable<Termék>();
                var table3 = teletabyDB.GetTable<Rendelés>();

                var result = (from t1 in table1
                              join t2 in table2
                              on t1.termékID equals t2.ID
                              join t3 in table3 on t1.rendelésID equals t3.ID
                              where belepes.felhaszID == t2.felhaszID && t1.státusz == !b
                              select new LekérdezésHelper(t1.rendelésID, t3.idő, t2.név, t1.megjegyzés)).ToList<LekérdezésHelper>();

                rendelesek = result.ToBindingList<LekérdezésHelper>();
                dataGridViewRendelesek.DataSource = rendelesek;
            }
            rowColoring(dataGridViewRendelesek);

            rowSelect();
        }
        

        private void rowSelect()
        {
            if (lastSelectedRowIndex+1 > dataGridViewRendelesek.Rows.Count)
            {
                lastSelectedRowIndex = dataGridViewRendelesek.Rows.Count-1;
            }
            try
            {
                dataGridViewRendelesek.Rows[0].Selected = false;
                dataGridViewRendelesek.Rows[lastSelectedRowIndex].Selected = true;
            }
            catch (Exception)
            {
            }

            
        }



        private void TimerLekerdez_Tick(object sender, EventArgs e)
        {
            lekerdezRendelesek(mitKerdezLe);
        }
        private void TimerIdo_Tick(object sender, EventArgs e)
        {
            labelIdo.Text = DateTime.Now.ToString("HH:mm:ss");
        }


        private void ButtonKilep_Click(object sender, EventArgs e)
        {
             Application.Exit();
        }

        int lastSelectedRowIndex = 0;
        private void DataGridViewRendelesek_SelectionChanged(object sender, EventArgs e)
        {

            if (dataGridViewRendelesek.Rows.Count>1 && dataGridViewRendelesek.SelectedCells.Count != 0)
            {
                lastSelectedRowIndex = dataGridViewRendelesek.SelectedRows[0].Index;

                if (dataGridViewRendelesek.SelectedRows[0].DefaultCellStyle.BackColor.Name == "Yellow")
                {
                    dataGridViewRendelesek.DefaultCellStyle.SelectionBackColor = Color.Yellow;
                }
                else
                {
                    dataGridViewRendelesek.DefaultCellStyle.SelectionBackColor = Color.White;
                }
                dataGridViewRendelesek.DefaultCellStyle.SelectionForeColor = Color.Black;                
            }
            
        }
        
        //sor keret szin
        private void DataGridViewRendelesek_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (dataGridViewRendelesek.SelectedCells.Count > 0)
            {
                if (e.RowIndex == dataGridViewRendelesek.SelectedCells[0].RowIndex)
                {
                    e.PaintCells(e.RowBounds, DataGridViewPaintParts.Border);
                    using (Pen p = new Pen(Color.Blue, 3))
                    {
                        Rectangle rect = e.RowBounds;

                        rect.Height -= 2;

                        e.Graphics.DrawRectangle(p, rect);
                    }               
                }
            }
        }        
    }



    static class Extension
    {
        public static BindingList<T> ToBindingList<T>(this IList<T> source)
        {
            return new BindingList<T>(source);
        }
    }
}
