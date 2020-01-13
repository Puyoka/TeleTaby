using System;
using System.Data;
using System.Data.Linq;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;

namespace testDesign
{
    public partial class belepes : Form
    {
        public belepes()
        {
            InitializeComponent();
        }

        public static string connectionString = ConfigurationManager.ConnectionStrings["teletabyDB"].ToString();
        private void Belepes_Load(object sender, EventArgs e)
        {
            using (var teletabyDB = new DataContext(connectionString))
            {
                var felhasznaloT = teletabyDB.GetTable<Felhasználó>();

                var result = from t in felhasznaloT
                             select t.név;

                comboBoxFelhaszn.DataSource = result;
                comboBoxFelhaszn.SelectedItem = null;
            }
        }


        public static string felhaszNev { get; set; }
        public static int felhaszID { get; set; }
        public int UI_ID;
        private void buttonBejelentkezes_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (comboBoxFelhaszn.Text != "" && textBoxJelszo.Text != "")
            {
                felhaszNev = comboBoxFelhaszn.Text;
                string megadottJelszo = textBoxJelszo.Text;
                string helyesJelszo = megadottJelszo + "sad";


                using (var teletabyDB = new DataContext(connectionString))
                {
                    var felhasznaloT = teletabyDB.GetTable<Felhasználó>();

                    var result = from t in felhasznaloT
                                 where t.név == felhaszNev
                                 select new { t.ID, t.név, t.jelszó, t.UI,  };
                    if (result.FirstOrDefault() != null)
                    {
                        helyesJelszo = result.FirstOrDefault().jelszó;
                        UI_ID = result.FirstOrDefault().UI;
                        felhaszID = result.FirstOrDefault().ID; 
                    }                    
                }


                if (megadottJelszo == helyesJelszo.ToString())
                {
                    this.Hide();

                    switch (UI_ID)
                    {
                        case 1:
                            UI1 ui1 = new UI1();
                            ui1.Show();
                            break;
                        case 2:
                            UI2 ui2 = new UI2();
                            ui2.Show();
                            break;
                        case 3:
                            UI3 ui3 = new UI3();
                            ui3.Show();
                            break;
                    }
                }
                else
                {
                    errorProvider1.SetError(buttonBejelentkezes, "Hibás jelszó!");
                }
            }
            else
            {
                if (comboBoxFelhaszn.Text == "")
                {
                    errorProvider1.SetError(comboBoxFelhaszn, "Válaszza ki a felhasználónevet!");
                }
                else
                {
                    errorProvider1.SetError(textBoxJelszo, "Adja meg a jelszót!");
                }
            }
        }

        
        private void TextBoxJelszo_Enter(object sender, EventArgs e)
        {
            this.Width = 588;
        }
        private void ComboBoxFelhaszn_Enter(object sender, EventArgs e)
        {
            this.Width = 334;
        }

        
        private void NumButton_Click(object sender, EventArgs e)
        {
            NumButtonCall((sender as Button).Text);
        }
        public void NumButtonCall(string text)
        {
            if (text == "←" && textBoxJelszo.Text.Length > 0)
            {
                textBoxJelszo.Text = textBoxJelszo.Text.Remove(textBoxJelszo.Text.Length - 1, 1);
            }
            else if (text == "ENT")
            {
                this.Width = 334;
                buttonBejelentkezes_Click(new object(), new EventArgs());
            }
            else if (text != "ENT" && text != "←")
            {
                textBoxJelszo.Text += text;
            }
        }


        private void TextBoxJelszo_KeyPress(object sender, KeyPressEventArgs e)
        {
            BelepesTriggerIfEnter(e);
        }
        private void Belepes_KeyPress(object sender, KeyPressEventArgs e)
        {
            BelepesTriggerIfEnter(e);
        }
        private void BelepesTriggerIfEnter(KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                buttonBejelentkezes_Click(new object(), new EventArgs());
            }
        }


        private void buttonKilep_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
