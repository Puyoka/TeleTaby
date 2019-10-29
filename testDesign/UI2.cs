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

            lekerdezNemKesz();
            lekerdezKesz();
            keszCount = keszCounter();
            labelCounter.Text = $"{keszCount}";

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
                    teletabyDB.ExecuteCommand($"UPDATE TOP(1) rendelés_tételek SET státusz='true' WHERE rendelésID = '{row.Cells[0].Value}' AND termékNév = '{row.Cells[2].Value}' AND megjegyzés ='{row.Cells[3].Value}' AND felhasználóNév = '{row.Cells[4].Value}' AND státusz = '0'");
                }
                dataGridViewRendelesek.Rows.RemoveAt(dataGridViewRendelesek.SelectedRows[0].Index);
                //colors.RemoveAt(dataGridViewRendelesek.SelectedRows[0].Index);

                keszCount++;
                labelCounter.Text = $"{keszCount}";
                rowColoring(dataGridViewRendelesek);
            }
        }

        #region előzmények <-> rendelések
        private void ButtonElozmenyek_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            lekerdezKesz();
        }

        private void ButtonVissza_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = !groupBox1.Visible;
            groupBox2.Visible = !groupBox2.Visible;
        }
        #endregion



        static int keszCounter()
        {
            using (var teletabyDB = new DataContext(belepes.connectionString))
            {
                var table1 = teletabyDB.GetTable<Rendelés_tételek>();
                var table2 = teletabyDB.GetTable<Termék>();

                var result = (from t1 in table1
                              join t2 in table2
                              on t1.termékNév equals t2.név
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

        #region lekerdezesek
        BindingList<LekérdezésHelper> keszRendelesek = new BindingList<LekérdezésHelper>();
        BindingList<LekérdezésHelper> nemKeszRendelesek = new BindingList<LekérdezésHelper>();

        private void lekerdezNemKesz()
        {
            nemKeszRendelesek.Clear();
            using (var teletabyDB = new DataContext(belepes.connectionString))
            {
                var table1 = teletabyDB.GetTable<Rendelés_tételek>();
                var table2 = teletabyDB.GetTable<Termék>();
                var table3 = teletabyDB.GetTable<Rendelés>();

                var result = (from t1 in table1
                              join t2 in table2
                              on t1.termékNév equals t2.név
                              join t3 in table3 on t1.rendelésID equals t3.ID
                              where belepes.felhaszID == t2.felhaszID && t1.státusz == false
                              select new LekérdezésHelper(t1.rendelésID, t3.idő, t1.termékNév, t1.megjegyzés, t1.felhasználóNév)).ToList<LekérdezésHelper>();

                nemKeszRendelesek = result.ToBindingList<LekérdezésHelper>();
                dataGridViewRendelesek.DataSource = nemKeszRendelesek;
            }
            rowColoring(dataGridViewRendelesek);
        }

        private void lekerdezKesz()
        {
            keszRendelesek.Clear();
            using (var teletabyDB = new DataContext(belepes.connectionString))
            {
                var table1 = teletabyDB.GetTable<Rendelés_tételek>();
                var table2 = teletabyDB.GetTable<Termék>();
                var table3 = teletabyDB.GetTable<Rendelés>();

                var result = (from t1 in table1
                              join t2 in table2
                              on t1.termékNév equals t2.név
                              join t3 in table3 on t1.rendelésID equals t3.ID
                              where belepes.felhaszID == t2.felhaszID && t1.státusz == true
                              select new LekérdezésHelper(t1.rendelésID, t3.idő, t1.termékNév, t1.megjegyzés, t1.felhasználóNév)).ToList<LekérdezésHelper>();

                keszRendelesek = result.ToBindingList<LekérdezésHelper>();
                dataGridViewElozmenyek.DataSource = keszRendelesek;
            }
            rowColoring(dataGridViewElozmenyek);
        }
        #endregion



        private void TimerLekerdez_Tick(object sender, EventArgs e)
        {
            lekerdezNemKesz();
        }
        private void TimerIdo_Tick(object sender, EventArgs e)
        {
            labelIdo.Text = DateTime.Now.ToString("HH:mm:ss");
        }


        private void ButtonKilep_Click(object sender, EventArgs e)
        {
             Application.Exit();
        }

        private void DataGridViewElozmenyek_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
