using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;




namespace testDesign
{
    public partial class Email : Form
    {
        public string currFocus { get; set; }//prop amit a bill.ből olvasok majd

        public Email()
        {
            InitializeComponent();
        }
        Form incomingForm;
        public Email(Form incomingForm_)
        {
            InitializeComponent();
            incomingForm = incomingForm_;
        }
        

        private void Email_Load(object sender, EventArgs e)
        {
            var screenHeight = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, screenHeight - this.Height);

            tbTargy.Text = belepes.felhaszNev + " - ";
        }

        private void bKuldes_Click(object sender, EventArgs e)
        {            
            try
            {
                var fromEmail = ConfigurationManager.AppSettings["fromEmail"];
                var fromEmailPW = ConfigurationManager.AppSettings["fromEmailPW"];
                var toEmail = ConfigurationManager.AppSettings["toEmail"];


                var message = new MimeMessage();
                
                message.From.Add(new MailboxAddress(fromEmail));
                message.To.Add(new MailboxAddress(toEmail));
                message.Subject = tbTargy.Text;

                message.Body = new TextPart("plain")
                {
                    Text = $@"{tbUzenet.Text}"
                };

                using (var client = new SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 587);
                    client.AuthenticationMechanisms.Remove("XOAUTH2");
                    client.Authenticate(fromEmail, fromEmailPW);
                    client.Send(message);
                    client.Disconnect(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Email küldése sikertelen volt.\n{ex.Message}","Hiba!",MessageBoxButtons.OK);
            }
            if (incomingForm != null)
            {
                incomingForm.Close();
            }
            this.Close();
        }

        private void bMegse_Click(object sender, EventArgs e)
        {
            if (incomingForm != null)
            {
                incomingForm.Close();
            }
            this.Close();
        }

        private void tb_Enter(object sender, EventArgs e)//melyik tb van focusba, melyikbe írunk
        {
            TextBox tb = sender as TextBox;
            currFocus = tb.Name;
        }
    }
}
