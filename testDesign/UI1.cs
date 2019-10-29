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

        int osszeg = 0;
        int currRendelesID;
        TreeView tv = new TreeView();
        private void UI1_Load(object sender, EventArgs e)
        {
            CultureInfo ci = new CultureInfo("hu-HU");
            labelDatum.Text = DateTime.Now.ToString("yyyy-MM-dd")+ Environment.NewLine + DateTime.Now.ToString("dddd", ci).ToUpper();
            tIdo.Enabled = true;
            
            string file = @"C:\Users\user\Desktop\winform13_tree\winform13_tree\bin\Debug\test";
            LoadTree(tv,file);
            foreach (var item in tv.Nodes)
            {
                dgvCsoportok.Rows.Add(Convert.ToString(item).Split(' ')[1]);
            }

            LeadottRendelesekBeolvasasa();
        }
        private void DgvCsoportok_SelectionChanged(object sender, EventArgs e)
        {
            dgvTermékek.Rows.Clear();
            int index = dgvCsoportok.CurrentCell.RowIndex;
            foreach (var item in tv.Nodes[index].Nodes)
            {
                var temp = Convert.ToString(item).Split(' ')[1];
                var termAr = temp.Split('/');
                dgvTermékek.Rows.Add(termAr[0],termAr[1]);
            }
        }
        

        

        private void BPlus_Click(object sender, EventArgs e)
        {
            var termek = dgvTermékek.SelectedCells[0].Value;
            int ar = Convert.ToInt32(dgvTermékek.SelectedCells[1].Value);

            var strg = String.Format("{0,-20}\t{1,36}",termek,ar);
            lbRendelesLista.Items.Add(strg);

            OsszegUpdate('+', ar);
        }
        private void BMinus_Click(object sender, EventArgs e)
        {
            if (lbRendelesLista.SelectedIndex > -1)
            {
                string row = lbRendelesLista.SelectedItem.ToString();
                var temp = row.Split(' ');
                int ar = Convert.ToInt32(temp[temp.Length-1]);

                OsszegUpdate('-', ar);

                lbRendelesLista.Items.RemoveAt(lbRendelesLista.SelectedIndex);
            }            
        }



        

        private void BMegjegyzes_Click(object sender, EventArgs e)
        {
            int index = lbRendelesLista.SelectedIndex;
            //kell a bill :/
        }


        private void BLead_Click(object sender, EventArgs e)//ha lesz megjegyzés, igazítani kell
        {
            RendelesFeltolt();
            RendelesTetelekFeltolt();

            OsszegUpdate(' ', 0);
            lbRendelesLista.Items.Clear();

            LeadottRendelesekBeolvasasa();
        }        

        private void DgvRendelesek_SelectionChanged(object sender, EventArgs e)
        {
            LeadottRendelesTetelekBeolvasas();
        }



        public static void LoadTree(TreeView tree, string filename)
        {
            using (Stream file = File.Open(filename, FileMode.Open))
            {
                BinaryFormatter bf = new BinaryFormatter();
                object obj = bf.Deserialize(file);

                TreeNode[] nodeList = (obj as IEnumerable<TreeNode>).ToArray();
                tree.Nodes.AddRange(nodeList);
            }
        }
        public void OsszegUpdate(char jel, int ar)
        {
            if (jel == '-')
            {
                osszeg -= ar;
                labelOsszeg.Text = String.Format($"{osszeg}Ft");
            }
            if (jel == '+')
            {
                osszeg += ar;
                labelOsszeg.Text = String.Format($"{osszeg}Ft");
            }
            if (ar == 0)
            {
                osszeg = 0;
                labelOsszeg.Text = String.Format($"{osszeg}Ft");
            }
        }
        public void RendelesFeltolt()
        {
            var ido = DateTime.Now.ToString("yyyy - MM - dd HH: mm:ss");
            //var temp = DateTime.Now.ToString("s");
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
                foreach (var item in lbRendelesLista.Items)
                {
                    string megjegy = "";
                    var termekMegjegyAr = item.ToString().Split(' ');
                    if (!(termekMegjegyAr.Length == 2))
                    {
                        megjegy = termekMegjegyAr[1];
                    }
                    teletabyDB.ExecuteCommand($"INSERT INTO rendelés_tételek VALUES ('{currRendelesID}','{termekMegjegyAr[0]}','{megjegy}','{belepes.felhaszNev}','false')");
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
            catch (Exception ex)
            {
            }
            if (dgvRendelesek.Rows.Count > 0)
            {
                using (var teletabyDB = new DataContext(belepes.connectionString))
                {
                    var table1 = teletabyDB.GetTable<Rendelés_tételek>();
                    var table3 = teletabyDB.GetTable<Rendelés>();

                    var result = from t1 in table1
                                 join t3 in table3 on t1.rendelésID equals t3.ID
                                 where t3.ID == selectedRendelID
                                 select new { t1.termékNév, t1.megjegyzés };

                    dgvTetelek.DataSource = result;

                    var statuszok = from t1 in table1
                                    join t3 in table3 on t1.rendelésID equals t3.ID
                                    where t3.ID == selectedRendelID
                                    select new { t1.státusz };

                    int i = 0;
                    foreach (var item in statuszok)
                    {
                        if (item.státusz == false)
                        {
                            dgvTetelek.EnableHeadersVisualStyles = false;
                            dgvTetelek.Rows[i].HeaderCell.Style.BackColor = Color.Yellow;
                            dgvTetelek.Rows[i].HeaderCell.Style.SelectionBackColor = Color.Yellow;
                        }
                        else
                        {
                            dgvTetelek.EnableHeadersVisualStyles = false;
                            dgvTetelek.Rows[i].HeaderCell.Style.BackColor = Color.Green;
                            dgvTetelek.Rows[i].HeaderCell.Style.SelectionBackColor = Color.Green;
                        }
                        i++;
                    }
                }
            }
        }


        private void TIdo_Tick(object sender, EventArgs e)
        {
            labelIdo.Text = DateTime.Now.ToString("HH:mm:ss");
        }
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

        private void BKesz_Click(object sender, EventArgs e)
        {
            if (dgvTetelek.Rows.Count > 0)
            {
                using (var teletabyDB = new DataContext(belepes.connectionString))
                {
                    var Trow = dgvTetelek.Rows[dgvTetelek.SelectedRows[0].Index];
                    var Rrow = dgvRendelesek.Rows[dgvRendelesek.SelectedRows[0].Index];
                    teletabyDB.ExecuteCommand($"UPDATE TOP(1) rendelés_tételek " +
                        $"SET státusz='true' " +
                        $"WHERE rendelésID = '{Rrow.Cells[0].Value}' " +
                        $"AND termékNév = '{Trow.Cells[0].Value}' AND megjegyzés ='{Trow.Cells[1].Value}' AND felhasználóNév = '{belepes.felhaszNev}' AND státusz = '0'");//!!termék id == pultos id
                }
                LeadottRendelesTetelekBeolvasas();
            }
        }
    }
}
