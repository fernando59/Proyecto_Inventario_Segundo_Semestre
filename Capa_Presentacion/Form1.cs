using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
namespace prueba_Mensaje
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

        private void button1_Click(object sender, EventArgs e)
        {
            MailMessage mensaje = new MailMessage();
            mensaje.To.Add(txtPara.Text);
            mensaje.Subject= txtAsunto.Text;
            mensaje.SubjectEncoding = Encoding.UTF8;
            mensaje.Body=txtBody.Text;
            mensaje.BodyEncoding = Encoding.UTF8;
            mensaje.IsBodyHtml = true;
            mensaje.From = new MailAddress("fer_mercado_2000@hotmail.com");
            SmtpClient cliente = new SmtpClient();
            cliente.Credentials =new  NetworkCredential("fer_mercado_2000@hotmail.com","familia2000");
            cliente.Port =25;
            cliente.EnableSsl = true;
            cliente.Host = "smtp.live.com";
            cliente.Send(mensaje);


        }
    }
}
