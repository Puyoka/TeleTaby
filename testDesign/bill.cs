using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testDesign
{
    public partial class bill : Form
    {
        int swi;
        Email email;
        public bill(int i)
        {
            InitializeComponent();
            swi = i;
            if (i == 2)
            {
                email = new Email(this);
                email.Show();                         
            }
        }

        public string megjegyzes { get; set; }
        private void Button_Click(object sender, EventArgs e)
        {
            var text = (sender as Button).Text;
            if (swi == 1)//megjegyzés
            {
                text = (sender as Button).Text;
                WriteToTB(text, tbMegjegyzes);
                if (text.Contains("ENT"))
                {
                    this.Close();
                }                
            }
            else//email
            {                
                if (email.currFocus == "tbTargy")
                {
                    text = (sender as Button).Text;
                    WriteToTB(text, email.tbTargy);                    
                }
                else if (email.currFocus == "tbUzenet")
                {
                    text = (sender as Button).Text;
                    WriteToTB(text, email.tbUzenet);                    
                }
            }
        }
        static void WriteToTB(string text,TextBox tb)
        {
            if (text == "SPACE")
            {
                text = " ";
            }
            else if (text == "←")
            {
                text = "";
                if (tb.Text != "")
                {
                    tb.Text = tb.Text.Remove(tb.Text.Length - 1, 1);
                }
            }
            else if (text.Contains("ENT") && tb.Name == "tbMegjegyzes")
            {
                text = "";
                UI1.megjegyzes = tb.Text.Trim();                
                tb.Clear();
            }
            else if (text.Contains("ENT") && (tb.Name == "tbUzenet" || tb.Name == "tbTargy"))
            {
                text = "\n";                
            }

            if (tb.Name == "tbUzenet" || tb.Name == "tbTargy")
            {
                tb.Focus();
            }
            tb.AppendText(text);
        }


        private void bKilep_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bill_Load(object sender, EventArgs e)
        {
            var screenWidth = Screen.PrimaryScreen.Bounds.Width;
            var screenHeight = Screen.PrimaryScreen.Bounds.Height;
            if (swi == 1)//megjegyzés
            {
                this.Location = new Point(0, screenHeight - this.Height);
            }
            else//email
            {                
                tbMegjegyzes.Hide();
                bKilep.Hide();

                this.Height = this.Height - tbMegjegyzes.Height;
                this.Location = new Point(227, screenHeight - this.Height);
            }          
        }        
    }
}
