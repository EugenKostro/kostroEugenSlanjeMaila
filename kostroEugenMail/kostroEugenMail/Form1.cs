using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;

namespace kostroEugenMail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1Posalji_Click(object sender, EventArgs e)
        {
            
            
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("kostro.eugen@gmail.com", "Baustelci1");
                MailMessage msg = new MailMessage();
                msg.To.Add(textBoxPrima.Text);
                msg.From = new MailAddress("kostro.eugen@gmail.com");
                msg.Subject = textBoxSubjekt.Text;
                msg.Body = richTextBoxPoruka.Text;
                client.Send(msg);
                MessageBox.Show("Poslano!");
                
            
            
        }
    }
}
