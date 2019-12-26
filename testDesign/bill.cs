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
        public bill()
        {
            InitializeComponent();
        }

        public string megjegyzes { get; set; }
        private void Button_Click(object sender, EventArgs e)
        {
            var text = (sender as Button).Text;

            if (text == "SPACE")
            {
                text = " ";
            }
            else if (text == "←")
            {
                text = "";
                if (tbMegjegyzes.Text != "")
                {
                    tbMegjegyzes.Text = tbMegjegyzes.Text.Remove(tbMegjegyzes.Text.Length - 1, 1);
                }
            }
            else if (text.Contains("ENT"))
            {
                text = "";
                UI1.megjegyzes = tbMegjegyzes.Text.Trim();                
                this.Hide();                
                tbMegjegyzes.Clear();
            }
            tbMegjegyzes.AppendText(text);
        }

        private void bKilep_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
