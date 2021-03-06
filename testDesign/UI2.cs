﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Globalization;
using System.Linq;
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

        private void UI2_Load(object sender, EventArgs e)
        {
            CultureInfo ci = new CultureInfo("hu-HU");
            labelNap.Text = DateTime.Now.ToString("dddd", ci).ToUpper();
            labelIdo.Text = DateTime.Now.ToString("HH:mm:ss");

            lekerdezRendelesek(mitKerdezLe);
            keszCount = keszCounter();
            labelCounter.Text = $"{keszCount}";
            lFelhaszNev.Text = belepes.felhaszNev;
            lRendEl.Width = this.Width;

            dgvRendelesek.RowHeadersDefaultCellStyle.Padding = new Padding(100);//ne legyen nyil
            dgvRendelesek.RowHeadersDefaultCellStyle.SelectionBackColor = Color.White;

            timerIdo.Start();
            timerLekerdez.Start();
        }


        private void ButtonKesz_Click(object sender, EventArgs e)
        {
            if (dgvRendelesek.Rows.Count > 0 && dgvRendelesek.SelectedRows.Count>0 )//ha van kijelölve
            {
                try
                {
                    using (var teletabyDB = new DataContext(belepes.connectionString))
                    {
                        var row = dgvRendelesek.Rows[dgvRendelesek.SelectedRows[0].Index];
                        var nev = row.Cells[2].Value.ToString().Split('/')[0];
                        string mertekegyseg = "";
                        if (row.Cells[2].Value.ToString().Split('/').Length > 1)
                        {
                            mertekegyseg = row.Cells[2].Value.ToString().Split('/')[1];
                        }



                        var termek = teletabyDB.GetTable<Termék>().FirstOrDefault(term => term.név == nev && term.mértékegység == mertekegyseg);
                      



                        var rendelesTetel = teletabyDB.GetTable<Rendelés_tételek>().FirstOrDefault(tetel => tetel.rendelésID == (int)row.Cells[0].Value &&
                                                                                                                    tetel.termékID == termek.ID &&
                                                                                                                    tetel.státusz == false);
                        rendelesTetel.státusz = true;
                        teletabyDB.SubmitChanges();

                    }
                }
                catch (NullReferenceException)
                {

                }
                int index = dgvRendelesek.SelectedRows[0].Index;
                dgvRendelesek.Rows.RemoveAt(index);
                colors.RemoveAt(index);

                keszCount++;
                labelCounter.Text = $"{keszCount}";
                rowColoring(dgvRendelesek);
                rowSelect();
            }
        }

       
        bool mitKerdezLe = true;
        private void ButtonElozmeny_rendeles_Click(object sender, EventArgs e)
        {
            mitKerdezLe = !mitKerdezLe;
            if (mitKerdezLe == true)
            {
                lRendEl.Text = "Rendelések";
            }
            else
            {
                lRendEl.Text = "Előzmények";
            }
            lekerdezRendelesek(mitKerdezLe);
            buttonKesz.Visible = !buttonKesz.Visible;
        }       
        
        public int keszCount = 0;
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

        private void rowColoring(DataGridView dgv)
        {
            if (colors.Count == 0)          //COLORS HIBA
            {
                colors.Add(Color.White);
            }

            int currID;
            int prevID;
            currColor = colors[0];
            colors.Clear();

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
                currColor = Color.LightGray;
            }
            else
            {
                currColor = Color.White;
            }
        }
        #endregion
        private void elapsedTime(string ido, DataGridViewRow sor)
        {
            ido = ido.Substring(0, 5);

            var rendeles = Convert.ToDateTime(ido).ToShortTimeString();
            var most = DateTime.Now.ToShortTimeString();

            TimeSpan kulonbseg = DateTime.Parse(most) - DateTime.Parse(rendeles);
            int kulonbsegPercekben = kulonbseg.Minutes;
            int kulonbsegOrakban = kulonbseg.Hours;

            dgvRendelesek.EnableHeadersVisualStyles = false;
            if (kulonbsegPercekben >= 30 || kulonbsegOrakban > 0)
            {
                sor.HeaderCell.Style.BackColor = Color.Red;
                sor.HeaderCell.Style.SelectionBackColor = Color.Red;
            }
            else if (kulonbsegPercekben >= 15)
            {
                sor.HeaderCell.Style.BackColor = Color.Yellow;
                sor.HeaderCell.Style.SelectionBackColor = Color.Yellow;
            }
        }


        List<int> idList = new List<int>();
        BindingList<RendelésLekér> rendelesek = new BindingList<RendelésLekér>();        
        private async void lekerdezRendelesek(bool keresettStatusz)
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
                              where belepes.felhaszID == t2.felhaszID && t1.státusz == !keresettStatusz
                              select new RendelésLekér(t1.rendelésID, t3.idő, t2.név + "/" + t2.mértékegység, t1.megjegyzés,t3.felhasználóNév)).ToList<RendelésLekér>();




                rendelesek = result.ToBindingList<RendelésLekér>();
                dgvRendelesek.DataSource = rendelesek;                
            }
            rowColoring(dgvRendelesek);

            if (keresettStatusz)
            {
                for (int i = 0; i < dgvRendelesek.Rows.Count; i++)
                {
                    elapsedTime(dgvRendelesek.Rows[i].Cells[1].Value.ToString(), dgvRendelesek.Rows[i]);
                }
                await soundPlayer(rendelesek.OfType<RendelésLekér>().Select(l => l.ID).ToList());                
            }
            rowSelect();            
        }        
        private void rowSelect()
        {
            if (lastSelectedRowIndex+1 > dgvRendelesek.Rows.Count)
            {
                lastSelectedRowIndex = dgvRendelesek.Rows.Count-1;
            }

            if (dgvRendelesek.SelectedRows.Count > 0)
            {
                dgvRendelesek.Rows[0].Selected = false;
                if (lastSelectedRowIndex < 0)
                {
                    lastSelectedRowIndex = 0;
                }

                dgvRendelesek.Rows[lastSelectedRowIndex].Selected = true; 
            }
                    
        }
        private async Task soundPlayer(List<int> ujIdList)
        {
            if (idList != default)
	        {
                var tempList = ujIdList.Except(idList).ToList();
                if (tempList.Count != 0)
	            {
                    var player = new System.Media.SoundPlayer();
                    player.SoundLocation = "sound.wav";
                    player.Play();
	            } 
	        }
            idList = ujIdList;
            await Task.Yield();  
        }


        //SELECTIONBACKCOLOR
        int lastSelectedRowIndex = 0;
        private void DataGridViewRendelesek_SelectionChanged(object sender, EventArgs e)
        {

            if (dgvRendelesek.Rows.Count>1 && dgvRendelesek.SelectedCells.Count != 0)
            {
                lastSelectedRowIndex = dgvRendelesek.SelectedRows[0].Index;

                if (dgvRendelesek.SelectedRows[0].DefaultCellStyle.BackColor.Name == "LightGray")
                {
                    dgvRendelesek.DefaultCellStyle.SelectionBackColor = Color.LightGray;
                }
                else
                {
                    dgvRendelesek.DefaultCellStyle.SelectionBackColor = Color.White;
                }
                dgvRendelesek.DefaultCellStyle.SelectionForeColor = Color.Black;                
            }
            
        }
        
        //sor keret szin
        private void DataGridViewRendelesek_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (dgvRendelesek.SelectedCells.Count > 0)
            {
                if (e.RowIndex == dgvRendelesek.SelectedCells[0].RowIndex)
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



        //TIMEREK
        private void TimerLekerdez_Tick(object sender, EventArgs e) => lekerdezRendelesek(mitKerdezLe);
        private void TimerIdo_Tick(object sender, EventArgs e) => labelIdo.Text = DateTime.Now.ToString("HH:mm:ss");

        //KILÉP
        private void ButtonKilep_Click(object sender, EventArgs e) => Application.Exit();
    }
    static class Extension
    {
        public static BindingList<T> ToBindingList<T>(this IList<T> source) => new BindingList<T>(source);
    }
}
