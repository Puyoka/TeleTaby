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
            CsopNevekLekerdezes();
            TvFeltoltes();                        
        }
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
                var table = teletabyDB.GetTable<TermékTest>();

                var result = (from t in table
                              orderby t.gyűjtőnév ascending
                              select t.gyűjtőnév).ToHashSet();
                cbGyujtonev.DataSource = result.ToList();

                foreach (var item in result)
                {
                    tv.Nodes.Add(item);
                }

                var result2 = from t in table
                              select new { t.gyűjtőnév, t.név, t.ár };

                for (int i = 0; i < tv.Nodes.Count; i++)
                {
                    string gyujtonev = tv.Nodes[i].Text;
                    foreach (var item in result2)
                    {
                        if (item.gyűjtőnév == gyujtonev)
                        {
                            tv.Nodes[i].Nodes.Add($"{item.név} ➔ {item.ár}");
                        }
                    }
                }
                tv.ExpandAll();
            }
        }



        private void cbTabla_SelectedIndexChanged(object sender, EventArgs e)
        {
            pTermek.Visible = false;

            switch (cbTabla.SelectedIndex)
            {
                case 1:
                    pTermek.Visible = true;
                    break;
                default:
                    break;
            }
        }



        private async void BVegrehajt_Click(object sender, EventArgs e)
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
                            teletabyDB.ExecuteCommand($"INSERT INTO termékTest VALUES ('{tbNev.Text}', '{tbMertekegyseg.Text}', '{Convert.ToInt32(tbAr.Text)}', '{cbGyujtonev.Text}', '{result.FirstOrDefault()}')");
                        }
                        catch (System.Data.SqlClient.SqlException)
                        {
                            MessageBox.Show("kétszer ugyanaz");
                        }
                        TvFeltoltes();
                        await Visszajelzes();
                    }
                    break;
                case 2:
                    try
                    {
                        using (var teletabyDB = new DataContext(belepes.connectionString))
                        {                            
                            string termekNev = tv.SelectedNode.Text.Split('➔')[0].Trim();
                            if (tv.SelectedNode.Parent == null)
                            {
                                teletabyDB.ExecuteCommand($"UPDATE termékTest SET gyűjtőnév = '{cbGyujtonev.Text}' WHERE gyűjtőnév = '{termekNev}'");
                            }
                            else
                            {
                                var table = teletabyDB.GetTable<Felhasználó>();
                                var result = from t in table
                                             where t.név == cbCsopNev.Text
                                             select t.ID;

                                teletabyDB.ExecuteCommand($"UPDATE TOP(1) termékTest SET név = '{tbNev.Text}',  mértékegység = '{tbMertekegyseg.Text}',  ár = '{Convert.ToInt32(tbAr.Text)}',  gyűjtőnév = '{cbGyujtonev.Text}',  csopID = '{result.FirstOrDefault()}' WHERE név = '{termekNev}'");                                
                            }                            
                            TvFeltoltes();
                            await Visszajelzes();
                        }
                    }
                    catch (NullReferenceException)
                    {
                        MessageBox.Show($"nincs semmi kiválasztava");
                    }   
                    break;
                case 3:

                    break;
                default:
                    break;
            }
        }
        private async Task Visszajelzes()
        {
            bVegrehajt.BackColor = Color.Green;
            bVegrehajt.Text = "✓";
            await Task.Delay(800);
            bVegrehajt.BackColor = Color.White;
            bVegrehajt.Text = "Végrehajt";
        }



        #region rbNUm
        private void Rb_CheckedChanged(object sender, EventArgs e)
        {
            rbNum = CurrRadButt(sender as RadioButton);
        }
        int rbNum = 1;
        static int CurrRadButt(RadioButton rb)
        {
            int num = 1;
            switch (rb.Name)
            {
                case "rbUj":
                    num = 1;
                    break;
                case "rbSzerk":
                    num = 2;
                    break;
                case "rbTorol":
                    num = 3;
                    break;
            }
            return num;
        }

        #endregion


        private void TbAr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
        private void Tv_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (rbNum == 2)
            {
                using (var teleetabyDB = new DataContext(belepes.connectionString))
                {
                    var table = teleetabyDB.GetTable<TermékTest>();

                    var result = from t in table
                                 where t.név == tv.SelectedNode.Text.Split('➔')[0].Trim()
                                 select new { t.gyűjtőnév, t.név, t.mértékegység, t.ár, t.csopID };

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
                        if (so.csopID != 0)
                        {
                            cbCsopNev.SelectedIndex = so.csopID - 1;
                        }
                        else
                        {
                            cbCsopNev.SelectedIndex = cbCsopNev.Items.Count-1;
                        }
                        
                    }
                }
            }
        }
    }
}
