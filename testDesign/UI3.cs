using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;



namespace testDesign
{

    //ha ki lett törölve a felhasználó amihez tartozik a termék, legyen piros
    //0 val NEM kezdődhet jelszó mert egyszerűen leszarja a llétezését



    public partial class UI3 : Form
    {
        public string  filePath { get; set; }

        public UI3()
        {
            InitializeComponent();

            CultureInfo ci = new CultureInfo("hu-HU");
            labelDatum.Text = DateTime.Now.ToString("yyyy-MM-dd") + Environment.NewLine + DateTime.Now.ToString("dddd", ci).ToUpper();

            filePath = @"C:\Users\puyok\Desktop\testtest\";

            tIdo.Enabled = true;
        }

        private void cbTabla_SelectedIndexChanged(object sender, EventArgs e)
        {
            pTermek.Visible = false;
            pFelhasz.Visible = false;
            pStat.Visible = false;
            pAdatbazis.Visible = false;

            switch (cbTabla.SelectedIndex)
            {
                case 0:
                    Meretez(599, 486);
                    pFelhasz.Visible = true;
                    CurrRadButt(SelectedRadianbutton(gbMuvFelhasz));
                    DgvFelhaszFeltolt();
                    break;
                case 1:
                    Meretez(542, 643);
                    pTermek.Visible = true;
                    CurrRadButt(SelectedRadianbutton(gbMuvTermek));
                    CsopNevekLekerdezes();
                    TvFeltoltes();
                    break;
                case 2:
                    Meretez(599, 945);
                    pStat.Visible = true;
                    Leker();
                    OsszegzoStat();
                    break;
                case 3:
                    Meretez(420, 602);
                    pAdatbazis.Visible = true;
                    cbAdatbazis.SelectedIndex = 1;
                    AdatbázisLekér();
                    break;
                default:
                    break;
            }
        }






        //---------
        void AdatbázisLekér()
        {
            switch (cbAdatbazis.SelectedIndex)
            {
                case 0:
                    using (var teletabyDB = new DataContext(belepes.connectionString))
                    {
                        var rendelesT = teletabyDB.GetTable<Rendelés>();                                                

                        var resultRend = (from t in rendelesT
                                          select new MentesRendeles(t.ID, t.idő, t.összeg)).AsEnumerable<MentesRendeles>();

                        dgvDT.DataSource = resultRend;
                    }
                    break;
                case 1:
                    using (var teletabyDB = new DataContext(belepes.connectionString))
                    {

                        var tetelT = teletabyDB.GetTable<Rendelés_tételek>();
                        var termekT = teletabyDB.GetTable<Termék>();

                        var resultTetel = (from t1 in tetelT
                                           join t2 in termekT on t1.termékID equals t2.ID
                                           select new MentesRendelesTetel(t1.rendelésID, t2.név, t2.mértékegység, t2.ár, t1.megjegyzés)).AsEnumerable<MentesRendelesTetel>();

                        dgvDT.DataSource = resultTetel;
                    }
                    break;
            }
        }



        private void cbAdatbazis_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdatbázisLekér();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            DialogResult valasz;
            if (cBoxMentes.Checked)
            {
                valasz = MessageBox.Show("Biztos benne, hogy véglegesen üríti a táblákat?", "Ürítés", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            else
            {
                valasz = MessageBox.Show("Biztos benne, hogy mentés nélkül, véglegesen üríti a táblákat?", "Ürítés", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }

            if (valasz == DialogResult.Yes)
            {
                using (var teletabyDB = new DataContext(belepes.connectionString))
                {
                    var rendelesT = teletabyDB.GetTable<Rendelés>();
                    var tetelT = teletabyDB.GetTable<Rendelés_tételek>();
                    var termekT = teletabyDB.GetTable<Termék>();


                    var resultRend = (from t in rendelesT
                                      select new MentesRendeles(t.ID, t.idő, t.összeg)).AsEnumerable<MentesRendeles>();
                    var resultTetel = (from t1 in tetelT
                                       join t2 in termekT on t1.termékID equals t2.ID
                                       select new MentesRendelesTetel(t1.rendelésID, t2.név, t2.mértékegység, t2.ár, t1.megjegyzés)).AsEnumerable<MentesRendelesTetel>();

                    switch (cbAdatbazis.SelectedIndex)
                    {
                        case 0:
                            dgvDT.DataSource = resultRend;
                            break;
                        case 1:
                            dgvDT.DataSource = resultTetel;
                            break;
                    }

                    if (cBoxMentes.Checked)
                    {
                        Excel(resultRend, resultTetel);
                    }

                    teletabyDB.ExecuteCommand("TRUNCATE TABLE rendelés");
                    teletabyDB.ExecuteCommand("TRUNCATE TABLE rendelés_tételek");
                }
                await Visszajelzes(bMentesUrites);

                AdatbázisLekér();
            }
        }

        void Excel(IEnumerable<MentesRendeles> dtRendeles, IEnumerable<MentesRendelesTetel> dtTetelek)
        {             
            using (ExcelPackage excel = new ExcelPackage())
            {
                excel.Workbook.Worksheets.Add("Rendelések");
                excel.Workbook.Worksheets.Add("Tételek");


                var dataArray = new List<object[]>();
                foreach (var item in dtRendeles)
                {
                    dataArray.Add(new object[] { item.ID,item.Idő.ToString(),item.Összeg});
                }                   
                var excelWorksheet = excel.Workbook.Worksheets["Rendelések"];
                excelWorksheet.Cells[1,1].LoadFromArrays(dataArray);


                dataArray = new List<object[]>();
                foreach (var item in dtTetelek)
                {
                    dataArray.Add(new object[] { item.RendelésID , item.Név , item.Mértékegység, item.Megjegyzés, item.Ár });
                }
                excelWorksheet = excel.Workbook.Worksheets["Tételek"];
                excelWorksheet.Cells[1, 1].LoadFromArrays(dataArray);



                FileInfo excelFile = new FileInfo(filePath + $"{DateTime.Now.ToShortDateString()}"+".xlsx");
                excel.SaveAs(excelFile);                
            }
        }

        
        //---------



        private RadioButton SelectedRadianbutton(GroupBox gb)
        {
            return gb.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked == true);
        }

        private void Meretez(int h, int w)
        {
            this.Height = h;
            this.Width = w;
        }        
        #region rbNUm
        private void Rb_CheckedChanged(object sender, EventArgs e)
        {
            rbNum = CurrRadButt(sender as RadioButton);
        }
        int rbNum = 1;
        private int CurrRadButt(RadioButton rb)
        {
            int num = 1;
            switch (rb.Text)
            {
                case "Új hozzáadása":
                    num = 1;
                    gbMezokTermek.Enabled = true;
                    gbMezokFelhasz.Enabled = true;
                    gbMezokTermek.Text = "Hozzáadás";                    
                    tbFelhsznev.Text = "";
                    tbJelszo.Text = "";
                    tbUI.Text = "";
                    break;
                case "Szerkesztés":
                    num = 2;
                    gbMezokTermek.Enabled = true;
                    gbMezokFelhasz.Enabled = true;
                    gbMezokTermek.Text = "Szerkesztés";
                    tbFelhsznev.Text = "";
                    tbJelszo.Text = "";
                    tbUI.Text = "";                    
                    break;
                case "Törlés":
                    num = 3;
                    gbMezokTermek.Enabled = false;
                    gbMezokTermek.Text = "";
                    cbGyujtonev.SelectedItem = "";
                    tbNev.Text = "";
                    tbMertekegyseg.Text = "";
                    tbAr.Text = "";
                    cbCsopNev.Text = "";
                    tbFelhsznev.Text = "";
                    tbJelszo.Text = "";
                    tbUI.Text = "";
                    gbMezokFelhasz.Enabled = false;                    
                    break;
            }
            return num;
        }
        #endregion
        private async Task Visszajelzes(Button b)
        {
            b.BackColor = Color.Green;
            b.Text = "✓";
            await Task.Delay(400);
            b.BackColor = Color.White;
            b.Text = "Végrehajt";
        }



        private void OnlyNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
        private bool Urese(List<Control> controlsToTest)
        {
            bool b = true;
            foreach (var item in controlsToTest)
            {
                if (item.Text == "")
                {
                    errorProvider.SetError(item, "Töltse ki a mezőt!");
                    b = false;
                }
            }
            return b;
        }
        private bool Foglalte()
        {
            for (int i = 0; i < dgvFelhasznalok.Rows.Count; i++)
            {
                if (rbNum == 2)
                {
                    var count = 0;
                    if (dgvFelhasznalok.Rows[i].Cells[0].Value.ToString() == tbFelhsznev.Text)
                    {
                        count++;
                    }
                    if (count < 2)
                    {
                        return false;
                    }
                }
                if (dgvFelhasznalok.Rows[i].Cells[0].Value.ToString() == tbFelhsznev.Text)
                {
                    errorProvider.SetError(tbFelhsznev, "Ez a felhasználónév már foglalt.");
                    return true;
                }
            }
            return false;
        }




        #region case 1:Termékek
        private void CsopNevekLekerdezes()
        {
            using (var teletabyDB = new DataContext(belepes.connectionString))
            {
                var table = teletabyDB.GetTable<Felhasználó>();

                var result = (from t in table
                              select t.név).ToList();
                result.Add("");

                cbCsopNev.DataSource = result;
            }
        }
        private void TvFeltoltes()
        {
            using (var teletabyDB = new DataContext(belepes.connectionString))
            {
                tv.Nodes.Clear();
                var table = teletabyDB.GetTable<Termék>();

                var result = (from t in table
                              orderby t.gyűjtőnév ascending
                              select t.gyűjtőnév).ToHashSet();
                cbGyujtonev.DataSource = result.ToList();

                foreach (var item in result)
                {
                    tv.Nodes.Add(item);
                }

                var result2 = from t in table
                              orderby t.név ascending
                              select new { t.gyűjtőnév, t.név, t.ár,t.mértékegység };

                for (int i = 0; i < tv.Nodes.Count; i++)
                {
                    string gyujtonev = tv.Nodes[i].Text;
                    foreach (var item in result2)
                    {
                        if (item.gyűjtőnév == gyujtonev)
                        {
                            tv.Nodes[i].Nodes.Add($"{item.név}_{item.mértékegység} ➔ {item.ár}");
                        }
                    }
                }
                tv.ExpandAll();
            }
        }


        private async void BVegrehajtTermek_Click(object sender, EventArgs e)
        {
            switch (rbNum)
            {
                case 1:
                    using (var teletabyDB = new DataContext(belepes.connectionString))
                    {
                        var table = teletabyDB.GetTable<Felhasználó>();

                        var result = from t in table
                                     where t.név == cbCsopNev.Text
                                     select t.ID;

                        try
                        {
                            teletabyDB.ExecuteCommand($"INSERT INTO termék VALUES ('{tbNev.Text}', '{tbMertekegyseg.Text}', '{Convert.ToInt32(tbAr.Text)}', '{cbGyujtonev.Text}', '{result.FirstOrDefault()}')");
                        }
                        catch (System.Data.SqlClient.SqlException)
                        {
                            MessageBox.Show("kétszer ugyanaz");
                        }
                        var selectedIndex = cbGyujtonev.SelectedIndex;
                        TvFeltoltes();
                        cbGyujtonev.SelectedIndex = selectedIndex;
                        await Visszajelzes(bVegrehajtTermek);
                    }
                    break;
                case 2:
                    try
                    {
                        using (var teletabyDB = new DataContext(belepes.connectionString))
                        {
                            string termekNev = tv.SelectedNode.Text.Split('➔')[0].Trim().Split('_')[0];
                            string mertekegyseg = tv.SelectedNode.Text.Split('➔')[0].Trim().Split('_')[1];
                            if (tv.SelectedNode.Parent == null)
                            {
                                teletabyDB.ExecuteCommand($"UPDATE termék SET gyűjtőnév = '{cbGyujtonev.Text}' WHERE gyűjtőnév = '{termekNev}'");
                            }
                            else
                            {
                                var table = teletabyDB.GetTable<Felhasználó>();
                                var result = from t in table
                                             where t.név == cbCsopNev.Text
                                             select t.ID;

                                teletabyDB.ExecuteCommand($"UPDATE TOP(1) termék SET név = '{tbNev.Text}',  mértékegység = '{tbMertekegyseg.Text}',  ár = '{Convert.ToInt32(tbAr.Text)}',  gyűjtőnév = '{cbGyujtonev.Text}',  felhaszID = '{result.FirstOrDefault()}' WHERE név = '{termekNev}' AND mértékegység = '{mertekegyseg}'");
                            }
                            TvFeltoltes();
                            await Visszajelzes(bVegrehajtTermek);
                        }
                    }
                    catch (NullReferenceException)
                    {
                        MessageBox.Show($"nincs semmi kiválasztava");
                    }
                    break;
                case 3:
                    try
                    {
                        string termekNev = tv.SelectedNode.Text.Split('➔')[0].Trim().Split('_')[0];
                        string mertekegyseg = tv.SelectedNode.Text.Split('➔')[0].Trim().Split('_')[1];
                        using (var teletabyDB = new DataContext(belepes.connectionString))
                        {
                            if (!(tv.SelectedNode.Parent == null))
                            {
                                var respond = MessageBox.Show($"Biztosan tölörlni szeretné a(z) {termekNev} tételt?", "Törlés", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                if (respond == DialogResult.Yes)
                                {
                                    teletabyDB.ExecuteCommand($"DELETE FROM termék WHERE név = '{termekNev}' AND mértékegység = '{mertekegyseg}'");
                                    TvFeltoltes();
                                    await Visszajelzes(bVegrehajtTermek);
                                }
                            }
                            else
                            {
                                MessageBox.Show("nem ehet csoportot törölni");
                            }
                        }
                    }
                    catch (NullReferenceException)
                    {
                        MessageBox.Show($"nincs semmi kiválasztava");
                    }
                    break;
                default:
                    break;
            }
        }      

        private void Tv_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (rbNum == 2)
            {
                if (tv.SelectedNode.Parent != null)
                {
                    using (var teleetabyDB = new DataContext(belepes.connectionString))
                    {
                        var table1 = teleetabyDB.GetTable<Termék>();
                        var table2 = teleetabyDB.GetTable<Felhasználó>();

                        string termekNev = tv.SelectedNode.Text.Split('➔')[0].Trim().Split('_')[0].Trim();
                        string mertekegyseg = tv.SelectedNode.Text.Split('➔')[0].Trim().Split('_')[1].Trim();
                        var result = from t1 in table1
                                     where t1.név == termekNev && t1.mértékegység == mertekegyseg
                                     select new { t1.gyűjtőnév, t1.név, t1.mértékegység, t1.ár,t1.felhaszID};

                        var so = result.FirstOrDefault();

                        cbGyujtonev.Text = so.gyűjtőnév;
                        tbNev.Text = so.név;
                        tbMertekegyseg.Text = so.mértékegység;
                        tbAr.Text = Convert.ToString(so.ár);

                        
                        if (so.felhaszID == 0)
                        {
                            cbCsopNev.Text = "";
                        }
                        else
                        {
                            var ressult2 = from t2 in table2
                                           where t2.ID == so.felhaszID
                                           select t2.név;
                            if (ressult2.FirstOrDefault() != null)
                            {
                                cbCsopNev.Text = ressult2.FirstOrDefault().ToString();
                            }
                            cbCsopNev.Text = "---";
                        }
                        
                    } 
                }
                else
                {
                    cbGyujtonev.SelectedItem = tv.SelectedNode.Text;
                    tbNev.Text = "";
                    tbMertekegyseg.Text = "";
                    tbAr.Text = "";
                    cbCsopNev.Text = "";
                }
            }            
        }
        #endregion
        #region case 2:Felhasználók
        private void DgvFelhaszFeltolt()
        {
            using (var teletabyDB = new DataContext(belepes.connectionString))
            {
                var table = teletabyDB.GetTable<Felhasználó>();

                var result = from t in table
                             select new { Felhasználónév = t.név, Jelszó = t.jelszó, t.UI };

                dgvFelhasznalok.DataSource = result;
            }
        }
        private async void BVegrehajtFelhasz_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            DataGridViewRow row = null;
            string felhasznev_ = "";
            string jelszo_ = "";
            int id_ = 0;

            if (rbNum != 1)
            {
                row = dgvFelhasznalok.SelectedRows[0];
                felhasznev_ = Convert.ToString(row.Cells[0].Value);
                jelszo_ = Convert.ToString(row.Cells[1].Value);
                id_ = Convert.ToInt32(row.Cells[2].Value);
            }

            List<Control> controlsToTest;
            switch (rbNum)
            {
                case 1:
                    controlsToTest = new List<Control>() { tbFelhsznev, tbJelszo, tbUI };
                    if (Urese(controlsToTest) && !Foglalte())
                    {
                        using (var teletabyDB = new DataContext(belepes.connectionString))
                        {
                            teletabyDB.ExecuteCommand($"INSERT INTO felhasználó VALUES('{tbFelhsznev.Text}','{tbJelszo.Text}','{tbUI.SelectedIndex + 1}')");
                        }
                        await Visszajelzes(bVegrehajtFelhasz);
                        DgvFelhaszFeltolt();
                    }
                    break;
                case 2:
                    controlsToTest = new List<Control>() { tbFelhsznev, tbJelszo, tbUI };
                    if (Urese(controlsToTest))
                    {
                        if (!Foglalte())
                        {
                            using (var teletabvDB = new DataContext(belepes.connectionString))
                            {
                                teletabvDB.ExecuteCommand($"UPDATE felhasználó SET név = '{tbFelhsznev.Text}', jelszó ='{tbJelszo.Text}', UI ='{tbUI.SelectedIndex + 1}' WHERE név = '{felhasznev_}' AND jelszó = '{jelszo_}' AND UI = '{id_}'");
                            }
                            await Visszajelzes(bVegrehajtFelhasz);
                            DgvFelhaszFeltolt();
                        }
                    }
                    break;
                case 3:
                    using (var teletabyDB = new DataContext(belepes.connectionString))
                    {
                        teletabyDB.ExecuteCommand($"DELETE FROM felhasználó WHERE név = '{felhasznev_}' AND jelszó = '{jelszo_}' AND UI = '{id_}'");
                    }
                    await Visszajelzes(bVegrehajtFelhasz);
                    DgvFelhaszFeltolt();
                    break;
                default:
                    break;
            }
        }

        private void DgvFelhasznalok_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFelhasznalok.Rows.Count > 0 && dgvFelhasznalok.SelectedRows.Count > 0 && rbNum == 2)
            {
                var row = dgvFelhasznalok.SelectedRows[0].Cells;
                tbFelhsznev.Text = (string)row[0].Value;
                tbJelszo.Text = (string)row[1].Value;
                switch (Convert.ToString(row[2].Value))
                {
                    case "1":
                        tbUI.SelectedItem = "Pultos";
                        break;
                    case "2":
                        tbUI.SelectedItem = "Munkás";
                        break;
                    case "3":
                        tbUI.SelectedItem = "Admin";
                        break;
                    default:
                        break;
                }

            }
        }
        #endregion
        #region case 3:Rendelések
        public int pageNum { get; set; }


        private void Leker()
        {
            switch (pageNum)
            {
                case 1:
                    using (var teletabyDB = new DataContext(belepes.connectionString))
                    {
                        var rendelesTetelT = teletabyDB.GetTable<Rendelés_tételek>();
                        var termekT = teletabyDB.GetTable<Termék>();
                        var rendelesT = teletabyDB.GetTable<Rendelés>();
                        var felhaszT = teletabyDB.GetTable<Felhasználó>();

                        bool b;
                        if (rbKesz.Checked == true)
                        {
                            b = true;
                        }
                        else
                        {
                            b = false;
                        }

                        dynamic result;
                        if (rbTerm.Checked == true)
                        {
                            result = from t1 in rendelesTetelT
                                     join t3 in rendelesT on t1.rendelésID equals t3.ID
                                     join t2 in termekT on t1.termékID equals t2.ID
                                     join t4 in felhaszT on t3.felhasználóNév equals t4.név
                                     where t1.státusz == b
                                     select new { t3.idő, t3.ID, FelhaszNev = t4.név, TermekNev = t2.név, t2.ár };
                        }
                        else
                        {
                            result = (from t1 in rendelesTetelT
                                      join t3 in rendelesT on t1.rendelésID equals t3.ID
                                      join t4 in felhaszT on t3.felhasználóNév equals t4.név
                                      where t1.státusz == b
                                      select new { t3.idő, t3.ID, FelhaszNev = t4.név, t3.összeg }).Distinct();
                        }
                        dgvStat.DataSource = result;
                    }
                    break;
                case 2:
                    using (var teletabyDB = new DataContext(belepes.connectionString))
                    {
                        var rendelesTetelT = teletabyDB.GetTable<Rendelés_tételek>();
                        var termekT = teletabyDB.GetTable<Termék>();
                        var rendelesT = teletabyDB.GetTable<Rendelés>();
                        var felhaszT = teletabyDB.GetTable<Felhasználó>();

                        var iq = (from t1 in rendelesTetelT
                                  join t2 in termekT on t1.termékID equals t2.ID
                                  select new { t2.név, t2.ár }).Distinct();

                        var x = from t1 in rendelesTetelT
                                join t2 in termekT on t1.termékID equals t2.ID
                                select new { t2.név, t1.státusz, t2.ár };



                        List<Statisztika> keszNemkeszLista = new List<Statisztika>();
                        foreach (var item in iq)
                        {
                            var keszNemkesz = new
                            {
                                kesz = x.Count(s => s.státusz == true && s.név == item.név),
                                nemkesz = x.Count(s => s.státusz == false && s.név == item.név),
                            };
                            int osszesen = keszNemkesz.kesz + keszNemkesz.nemkesz;
                            int osszeg = item.ár * osszesen;


                            var temp = new Statisztika(item.név, keszNemkesz.kesz, keszNemkesz.nemkesz, osszesen, osszeg);
                            keszNemkeszLista.Add(temp);
                        }
                        dgvStat.DataSource = keszNemkeszLista;
                    }
                    break;
                case 3:
                    using (var teletabyDB = new DataContext(belepes.connectionString))
                    {
                        var rendelesTetelT = teletabyDB.GetTable<Rendelés_tételek>();
                        var termekT = teletabyDB.GetTable<Termék>();
                        var rendelesT = teletabyDB.GetTable<Rendelés>();
                        var felhaszT = teletabyDB.GetTable<Felhasználó>();

                        var iq = from t in felhaszT
                                 where t.UI == 1
                                 select new { t.név };

                        var x = from t1 in rendelesT
                                select new { t1.felhasználóNév, t1.státusz, t1.összeg };



                        List<Statisztika> keszNemkeszLista = new List<Statisztika>();
                        foreach (var item in iq)
                        {
                            var keszNemkesz = new
                            {
                                kesz = x.Count(s => s.státusz == true && s.felhasználóNév == item.név),
                                nemkesz = x.Count(s => s.státusz == false && s.felhasználóNév == item.név),
                                osszeg = x.Sum(s => s.összeg)
                            };
                            int osszesen = keszNemkesz.kesz + keszNemkesz.nemkesz;

                            var temp = new Statisztika(item.név, keszNemkesz.kesz, keszNemkesz.nemkesz, osszesen, keszNemkesz.osszeg);
                            keszNemkeszLista.Add(temp);
                        }
                        dgvStat.DataSource = keszNemkeszLista;
                    }
                    break;
                case 4:
                    using (var teletabyDB = new DataContext(belepes.connectionString))
                    {
                        var rendelesTetelT = teletabyDB.GetTable<Rendelés_tételek>();
                        var termekT = teletabyDB.GetTable<Termék>();
                        var rendelesT = teletabyDB.GetTable<Rendelés>();
                        var felhaszT = teletabyDB.GetTable<Felhasználó>();

                        var iq = from t in felhaszT
                                 where t.UI == 2
                                 select new { t.név };

                        var x = from t1 in rendelesTetelT
                                join t2 in termekT on t1.termékID equals t2.ID
                                join t3 in felhaszT on t2.felhaszID equals t3.ID
                                select new { t1.státusz, t2.ár, t3.név };



                        List<Statisztika> keszNemkeszLista = new List<Statisztika>();
                        foreach (var item in iq)
                        {
                            var keszNemkesz = new
                            {
                                kesz = x.Count(s => s.státusz == true && s.név == item.név),
                                nemkesz = x.Count(s => s.státusz == false && s.név == item.név),
                            };
                            int osszesen = keszNemkesz.kesz + keszNemkesz.nemkesz;


                            var termekek = from t1 in termekT
                                           join t2 in felhaszT on t1.felhaszID equals t2.ID
                                           join t3 in rendelesTetelT on t1.ID equals t3.termékID
                                           where item.név == t2.név
                                           select new { t3.termékID, t1.ár };

                            int osszeg = 0;
                            foreach (var item_ in termekek)
                            {
                                osszeg += item_.ár;
                            }


                            var temp = new Statisztika(item.név, keszNemkesz.kesz, keszNemkesz.nemkesz, osszesen, osszeg);
                            keszNemkeszLista.Add(temp);
                        }
                        dgvStat.DataSource = keszNemkeszLista;
                    }
                    break;
            }
        }

        private void bFrissit_Click(object sender, EventArgs e)
        {
            OsszegzoStat();
            Leker();
        }

        private void bRight_Click(object sender, EventArgs e)
        {
            pageNum++;
            if (pageNum > 4)
            {
                pageNum = 1;
            }
            lTest.Text = pageNum.ToString();
            Leker();
            gbRejtes();
        }

        private void bLeft_Click(object sender, EventArgs e)
        {
            pageNum--;
            if (pageNum < 1)
            {
                pageNum = 4;
            }
            lTest.Text = pageNum.ToString();
            Leker();
            gbRejtes();
        }

        private void gbRejtes()
        {
            if (pageNum != 1)
            {
                gb1.Visible = false;
                gb2.Visible = false;
            }
            else
            {
                gb1.Visible = true;
                gb2.Visible = true;
            }
        }

        private void OsszegzoStat()
        {
            using (var teletabyDB = new DataContext(belepes.connectionString))
            {
                var rendelesTetelT = teletabyDB.GetTable<Rendelés_tételek>();
                var termekT = teletabyDB.GetTable<Termék>();
                var rendelesT = teletabyDB.GetTable<Rendelés>();
                var felhaszT = teletabyDB.GetTable<Felhasználó>();

                var osszRendeles = (from t in rendelesT
                                    select t.ID).Count();
                var osszTetel = (from t in rendelesTetelT
                                 select t.sorsz).Count();
                var osszBevetel = (from t in rendelesT
                                   select t.összeg).Sum();

                lOsszesRendeles.Text = $"Rendelések: {osszRendeles} db";
                lOsszesTetel.Text = $"Tételek: {osszTetel} db";
                lBevetel.Text = $"Bevétel: {osszBevetel} Ft";
            }
        }

        #endregion

        private void UI3_Load(object sender, EventArgs e)
        {
            cbTabla.SelectedIndex = 0;
            pageNum = 1;
        }

        private void bBezár_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tIdo_Tick(object sender, EventArgs e)
        {
            lIdo.Text = DateTime.Now.ToString("HH:mm:ss");
        }


    }
    
}
