using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testDesign
{
    public partial class UI1 : Form
    {        
        public UI1()
        {
            InitializeComponent();
        }

        //BELÉPÉSKOR
        int osszeg = 0;
        int currRendelesID;
        private void UI1_Load(object sender, EventArgs e)
        {
            CultureInfo ci = new CultureInfo("hu-HU");
            labelDatum.Text = DateTime.Now.ToString("yyyy-MM-dd") + Environment.NewLine + DateTime.Now.ToString("dddd", ci).ToUpper();
            tIdo.Enabled = true;

            dgvTetelek.RowHeadersDefaultCellStyle.Padding = new Padding(100);

            CsoportokFeltoltes();
            LeadottRendelesekBeolvasasa();
        }
        private void CsoportokFeltoltes()
        {
            using (var teletabyDB = new DataContext(belepes.connectionString))
            {
                var table = teletabyDB.GetTable<Termék>();

                var result = (from t in table
                              orderby t.gyűjtőnév ascending
                              select t.gyűjtőnév).ToHashSet();

                foreach (var item in result)
                {
                    dgvCsoportok.Rows.Add(item);
                }                
            }
        }
        private void DgvCsoportok_SelectionChanged(object sender, EventArgs e)
        {
            dgvTermékek.Rows.Clear();
            using (var teletabyDB = new DataContext(belepes.connectionString))
            {
                var table = teletabyDB.GetTable<Termék>();

                string gyujtonev = Convert.ToString(dgvCsoportok.SelectedRows[0].Cells[0].Value);
                var result = from t in table
                              where t.gyűjtőnév == gyujtonev
                              select new { t.név, t.mértékegység, t.ár };

                dgvTermékek.DataSource = result;                
            }

        }



        public static string megjegyzes { get; set; }
        public int termekSorIndex { get; set; }
        private void bElfogyott_Click(object sender, EventArgs e)
        {
            bill bill = new bill(2);            
            bill.Show();
        }
        private async void BMegjegyzes_Click(object sender, EventArgs e)
        {
            bill bill = new bill(1);
            termekSorIndex = dgvTermékek.SelectedRows[0].Index;
            bill.Show();
            while (bill.Visible == true)
            {
                await wait();
            }
            if (megjegyzes != "")
            {
                BPlus_Click(new object(), new EventArgs()); 
            }
        }
        static async Task wait()
        {
            await Task.Delay(500);
        }


        public void BPlus_Click(object sender, EventArgs e)
        {            
            if (megjegyzes == null)
            {
                megjegyzes = "";
            }
            if (dgvTermékek.Rows[termekSorIndex].Cells[1].Value.ToString() != "")
            {
                dgvRendelesLista.Rows.Add($"{dgvTermékek.SelectedCells[0].Value}\\{dgvTermékek.SelectedCells[1].Value}", megjegyzes, dgvTermékek.SelectedCells[2].Value);
            }
            else
            {
                dgvRendelesLista.Rows.Add($"{dgvTermékek.SelectedCells[0].Value}", megjegyzes, dgvTermékek.SelectedCells[2].Value);
            }
            megjegyzes = "";

            OsszegUpdate();
        }
        private void BMinus_Click(object sender, EventArgs e)
        {
            if (dgvRendelesLista.Rows.Count > 0)
            {
                dgvRendelesLista.Rows.RemoveAt(dgvRendelesLista.SelectedRows[0].Index);
                OsszegUpdate();                
            }            
        }
       
        
        private void BLead_Click(object sender, EventArgs e)//ha lesz megjegyzés, igazítani kell
        {
            RendelesFeltolt();
            RendelesTetelekFeltolt();

            dgvRendelesLista.Rows.Clear();
            OsszegUpdate();            

            LeadottRendelesekBeolvasasa();
        }        

        private void DgvRendelesek_SelectionChanged(object sender, EventArgs e)
        {
            LeadottRendelesTetelekBeolvasas();
        }


        public void OsszegUpdate()
        {
            osszeg = 0;
            for (int i = 0; i < dgvRendelesLista.Rows.Count; i++)
            {
                osszeg += Convert.ToInt32(dgvRendelesLista.Rows[i].Cells[2].Value);
            }
            labelOsszeg.Text = osszeg.ToString();
        }
        #region LE/FEL
        public void RendelesFeltolt()
        {
            var ido = DateTime.Now.ToString("yyyy - MM - dd HH: mm:ss");
            using (var teletabyDB = new DataContext(belepes.connectionString))
            {
                teletabyDB.ExecuteCommand($"INSERT INTO rendelés VALUES ('{ido}', '{belepes.felhaszNev}', '{osszeg}', '{0}')");

                var table_ = teletabyDB.GetTable<Rendelés>();
                currRendelesID = (from table in table_
                                  where table.felhasználóNév == belepes.felhaszNev
                                  orderby table.ID descending
                                  select table.ID).First();
            }
        }
        public void RendelesTetelekFeltolt()
        {
            using (var teletabyDB = new DataContext(belepes.connectionString))
            {
                for (int i = 0; i < dgvRendelesLista.Rows.Count; i++)
                {
                    var termekMertekegyseg = dgvRendelesLista.Rows[i].Cells[0].Value.ToString();
                    string termek = "";
                    string mertekegyseg = "";
                    if (termekMertekegyseg.Contains('\\'))
                    {
                        var temp = dgvRendelesLista.Rows[i].Cells[0].Value.ToString().Split('\\');
                        termek = temp[0];
                        mertekegyseg = temp[1];
                    }
                    else
                    {
                        termek = termekMertekegyseg;
                        mertekegyseg = "";
                    }

                    string megjegy = dgvRendelesLista.Rows[i].Cells[1].Value.ToString();
                    teletabyDB.ExecuteCommand($"INSERT INTO rendelés_tételek VALUES ('{currRendelesID}',(SELECT ID FROM termék WHERE név = '{termek}' AND mértékegység = '{mertekegyseg}'),'{megjegy}','false')");
                }
            }
        }
        public void LeadottRendelesekBeolvasasa()
        {
            using (var teletabyDB = new DataContext(belepes.connectionString))
            {
                var table = teletabyDB.GetTable<Rendelés>();

                var result = from t in table
                             where t.felhasználóNév == belepes.felhaszNev && t.státusz == false
                             select new { t.ID, t.idő.TimeOfDay };

                dgvRendelesek.DataSource = result;
            }

        }
        public void LeadottRendelesTetelekBeolvasas()
        {
            int selectedRendelID = 0;
            try
            {
                selectedRendelID = (int)dgvRendelesek.SelectedRows[0].Cells[0].Value;
            }
            catch (Exception)
            {
            }
            if (dgvRendelesek.Rows.Count > 0)
            {
                using (var teletabyDB = new DataContext(belepes.connectionString))
                {
                    var table1 = teletabyDB.GetTable<Rendelés_tételek>();
                    var table2 = teletabyDB.GetTable<Termék>();
                    var table3 = teletabyDB.GetTable<Rendelés>();

                    var result = from t1 in table1
                                 join t3 in table3 on t1.rendelésID equals t3.ID
                                 join t2 in table2 on t1.termékID equals t2.ID
                                 where t3.ID == selectedRendelID
                                 select new { t2.név, t2.mértékegység, t1.megjegyzés };

                    dgvTetelek.DataSource = result;

                    var statuszok = from t1 in table1
                                    join t3 in table3 on t1.rendelésID equals t3.ID
                                    where t3.ID == selectedRendelID
                                    select new { t1.státusz };

                    int i = 0;
                    dgvTetelek.EnableHeadersVisualStyles = false;
                    foreach (var item in statuszok)
                    {
                        if (item.státusz == false)
                        {
                            dgvTetelek.Rows[i].HeaderCell.Style.BackColor = Color.Yellow;
                            dgvTetelek.Rows[i].HeaderCell.Style.SelectionBackColor = Color.Yellow;
                        }
                        else
                        {
                            dgvTetelek.Rows[i].HeaderCell.Style.BackColor = Color.Green;
                            dgvTetelek.Rows[i].HeaderCell.Style.SelectionBackColor = Color.Green;
                        }
                        i++;
                    }
                }
            }
        }

        #endregion


        private void BKilep_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BLezar_Click(object sender, EventArgs e)
        {
            using (var teletabyDB = new DataContext(belepes.connectionString))
            {
                var table = teletabyDB.GetTable<Rendelés_tételek>();
                int selectedRendelID = (int)dgvRendelesek.SelectedRows[0].Cells[0].Value;
                bool b = true;

                var result = from t in table
                             where t.rendelésID == selectedRendelID
                             select t.státusz;

                foreach (var item in result)
                {
                    if (item == false)
                    {
                        b = false;
                    }
                }

                if (b)
                {
                    teletabyDB.ExecuteCommand($"UPDATE TOP(1) rendelés SET státusz='{1}' WHERE ID = '{selectedRendelID}'");
                    dgvRendelesek.Rows.RemoveAt(dgvRendelesek.SelectedRows[0].Index);
                    dgvTetelek.Rows.Clear();
                }
            }
            LeadottRendelesTetelekBeolvasas();
        }
        private void BKesz_Click(object sender, EventArgs e)//SAJÁT MAGA
        {
            if (dgvTetelek.Rows.Count > 0)
            {
                using (var teletabyDB = new DataContext(belepes.connectionString))
                {
                    var Trow = dgvTetelek.Rows[dgvTetelek.SelectedRows[0].Index];
                    var Rrow = dgvRendelesek.Rows[dgvRendelesek.SelectedRows[0].Index];
                    var nev = Trow.Cells[0].Value.ToString();
                    var mertekegyseg = Trow.Cells[1].Value.ToString();
                    teletabyDB.ExecuteCommand($"UPDATE TOP(1) rendelés_tételek " +
                        $"SET státusz='true' " +
                        $"WHERE rendelésID = '{Rrow.Cells[0].Value}' AND " +
                        $"(SELECT felhaszID FROM termék WHERE név = '{nev}' AND mértékegység = '{mertekegyseg}') = '0'" +
                        $"AND termékID = (SELECT ID FROM termék WHERE név = '{nev}' AND mértékegység = '{mertekegyseg}') " +
                        $"AND megjegyzés ='{Trow.Cells[1].Value}' AND státusz = '0'");

                }
                LeadottRendelesTetelekBeolvasas();
            }
        }


        private void Timer1_Tick(object sender, EventArgs e)
        {
            LeadottRendelesTetelekBeolvasas();
        }
        private void TIdo_Tick(object sender, EventArgs e)
        {
            labelIdo.Text = DateTime.Now.ToString("HH:mm:ss");
        }


    }
}
