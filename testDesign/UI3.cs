using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testDesign
{
    public partial class UI3 : Form
    {
        public UI3()
        {
            InitializeComponent();
        }

        private void UI3_Load(object sender, EventArgs e)
        {
                   
        }

        private void cbTabla_SelectedIndexChanged(object sender, EventArgs e)
        {
            pTermek.Visible = false;
            pFelhasz.Visible = false;

            switch (cbTabla.SelectedIndex)
            {
                case 0:
                    Méretez(599, 486);
                    pFelhasz.Visible = true;
                    DgvFelhaszFeltolt();
                    break;
                case 1:
                    Méretez(542, 643);
                    pTermek.Visible = true;
                    CsopNevekLekerdezes();
                    TvFeltoltes();
                    break;
                default:
                    break;
            }
        }

        private void Méretez(int h, int w)
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
                    gbMuvelet.Enabled = true;
                    gbMuvelet.Text = "Hozzáadás";
                    break;
                case "Szerkesztés":
                    num = 2;
                    gbMuvelet.Enabled = true;
                    gbMuvelet.Text = "Szerkesztés";
                    break;
                case "Töröl":
                    num = 3;
                    gbMuvelet.Enabled = false;
                    gbMuvelet.Text = "";
                    cbGyujtonev.SelectedItem = "";
                    tbNev.Text = "";
                    tbMertekegyseg.Text = "";
                    tbAr.Text = "";
                    cbCsopNev.Text = "";
                    tbFelhsznev.Text = "";
                    tbJelszo.Text = "";
                    tbUI.Text = "";
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
                        TvFeltoltes();
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
                using (var teleetabyDB = new DataContext(belepes.connectionString))
                {
                    var table = teleetabyDB.GetTable<Termék>();

                    string termekNev = tv.SelectedNode.Text.Split('➔')[0].Trim().Split('_')[0];
                    string mertekegyseg = tv.SelectedNode.Text.Split('➔')[0].Trim().Split('_')[1];
                    var result = from t in table
                                 where t.név == termekNev && t.mértékegység == mertekegyseg
                                 select new { t.gyűjtőnév, t.név, t.mértékegység, t.ár, t.felhaszID };

                    var so = result.FirstOrDefault();
                    if (so == null)
                    {
                        cbGyujtonev.SelectedItem = tv.SelectedNode.Text;
                        tbNev.Text = "";
                        tbMertekegyseg.Text = "";
                        tbAr.Text = "";
                        cbCsopNev.Text = "";
                    }
                    else
                    {
                        cbGyujtonev.Text = so.gyűjtőnév;
                        tbNev.Text = so.név;
                        tbMertekegyseg.Text = so.mértékegység;
                        tbAr.Text = Convert.ToString(so.ár);
                        if (so.felhaszID != 0)
                        {
                            cbCsopNev.SelectedIndex = so.felhaszID - 1;
                        }
                        else
                        {
                            cbCsopNev.SelectedIndex = cbCsopNev.Items.Count - 1;
                        }

                    }
                }
            }
        }
        #endregion



        private void DgvFelhaszFeltolt()
        {
            using (var teletabyDB = new DataContext(belepes.connectionString))
            {
                var table = teletabyDB.GetTable<Felhasználó>();

                var result = from t in table
                             select new {Felhasználónév = t.név,Jelszó = t.jelszó, t.UI};

                dgvFelhasznalok.DataSource = result;
            }
        }

        private async void BVegrehajtFelhasz_Click(object sender, EventArgs e)
        {
            switch (rbNum)
            {
                case 1:
                    using (var teletabyDB = new DataContext(belepes.connectionString))
                    {
                        teletabyDB.ExecuteCommand($"INSERT INTO felhasználó VALUES('{tbFelhsznev.Text}','{tbJelszo.Text}','{tbUI.SelectedIndex+1}')");
                    }
                    await Visszajelzes(bVegrehajtFelhasz);
                    break;
                case 2:
                    var row = dgvFelhasznalok.SelectedRows[0];
                    string felhasznev_ = Convert.ToString(row.Cells[0].Value);
                    string jelszo_ = Convert.ToString(row.Cells[1].Value);
                    int id_ = Convert.ToInt32(row.Cells[2].Value);

                    using (var teletabvDB = new DataContext(belepes.connectionString))
                    {
                        teletabvDB.ExecuteCommand($"UPDATE felhasználó SET név = '{tbFelhsznev.Text}', jelszó ='{tbJelszo.Text}', UI ='{Convert.ToInt32(tbUI.Text)}' WHERE név = '{felhasznev_}, jelszó = '{jelszo_}', ID = '{id_}'");
                    }
                    break;
                case 3:
                    
                    break;
                default:
                    break;
            }
        }

        private void DgvFelhasznalok_SelectionChanged(object sender, EventArgs e)
        {
            var row = dgvFelhasznalok.SelectedRows[0].Cells;
            tbFelhsznev.Text = (string)row[0].Value;
            tbJelszo.Text = (string)row[1].Value;
            tbUI.SelectedItem = (string)row[2].Value;
        }
    }
}
