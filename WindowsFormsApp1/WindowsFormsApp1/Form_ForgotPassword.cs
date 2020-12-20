using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net;
using System.Net.Mail;

namespace WindowsFormsApp1
{
    public partial class Form_ForgotPassword : Form
    {

        public Form_ForgotPassword()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string connectionString = "server = 35.198.31.209; user = tpvllanq; database = tpvllanquihueDB; port = 3306; password = 18653129a; SslMode=none";

            using (MySqlConnection mysqlcon = new MySqlConnection(connectionString))
            {
                string email = "";
                string contrasena = "";
                mysqlcon.Open();
                MySqlCommand mysqlcmd = new MySqlCommand("recoverPass", mysqlcon);
                mysqlcmd.Parameters.AddWithValue("_rut", txtRut.Text);
                mysqlcmd.CommandType = CommandType.StoredProcedure;
                MySqlDataReader result = mysqlcmd.ExecuteReader();
                if (result.Read())
                {
                    email = result.GetString(0).ToString();
                    contrasena = result.GetString(1).ToString();
                    enviarEmail(email, contrasena);
                    lbRespuesta.Text = "Su contraseña fue enviada a: " + result.GetString(0).ToString();
                    lbRespuesta.Visible = true;
                    lbMsge.Visible = true;
                } else
                {
                    lbRespuesta.Text = "No existen datos para este RUT";
                    lbRespuesta.Visible = true;
                }
                mysqlcon.Close();
            }
        }

        public void enviarEmail(string email, string contrasena)
        {
            MailMessage correo = new MailMessage();
            correo.From = new MailAddress("marcelotorres23.mt@gmail.com");
            correo.To.Add(email);
            correo.Subject = ("RECUPERA CONTRASEÑA");
            correo.Body = "Su contraseña es: " + contrasena;
            correo.Priority = MailPriority.High;

            SmtpClient ServerMail = new SmtpClient();
            ServerMail.Credentials = new NetworkCredential("marcelotorres23.mt@gmail.com", "18653129");
            ServerMail.Host = "smtp.gmail.com";
            ServerMail.Port = 587;
            ServerMail.EnableSsl = true;
            try
            {
                ServerMail.Send(correo);
            }catch (Exception e)
            {
                Console.WriteLine(e);
            }
            correo.Dispose();
        }
    }
}
