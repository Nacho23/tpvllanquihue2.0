using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWind, int wMsg, int wParam, int lParam);

        private void Form_Login_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;                
            }
            Console.WriteLine(txtUsuario.Text);
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DimGray;
            } else if (!txtUsuario.Text.Contains('-'))
            {
                string cadena = txtUsuario.Text;
                int largoString = txtUsuario.TextLength;
                int posicionGuion = largoString - 1;
                string primeraParte = cadena.Substring(0, largoString - 1);
                string segundaParte = cadena.Substring(largoString - 1, 1);
                txtUsuario.Text = primeraParte + "-" + segundaParte;
            }
        }

        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "")
            {
                txtContrasena.Text = "CONTRASEÑA";
                txtContrasena.ForeColor = Color.DimGray;
                txtContrasena.UseSystemPasswordChar = false;
            }
        }

        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "CONTRASEÑA")
            {
                txtContrasena.Text = "";
                txtContrasena.ForeColor = Color.LightGray;
                txtContrasena.UseSystemPasswordChar = true;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form_Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            string connectionString = "server = localhost; user = root; database = mydb; port = 3306; password = 1234; SslMode=none";

            using (MySqlConnection mysqlcon = new MySqlConnection(connectionString))
            {
                try
                {
                    mysqlcon.Open();


                    MySqlCommand mysqlcmd = new MySqlCommand("login", mysqlcon);
                    mysqlcmd.CommandType = CommandType.StoredProcedure;
                    mysqlcmd.Parameters.AddWithValue("_rut", txtUsuario.Text);
                    mysqlcmd.Parameters.AddWithValue("_contrasena", txtContrasena.Text);
                    MySqlDataReader result = mysqlcmd.ExecuteReader();
                    if (result.Read())
                    {
                        this.Hide();
                        Form1_Main form1_Main = new Form1_Main(txtUsuario.Text);
                        form1_Main.Show();
                    }
                    else
                    {
                        lblError.Text = "Usuario o Contraseña Incorrecta";
                        lblError.Visible = true;
                        txtContrasena.Text = "";
                        txtContrasena_Leave(null, e);
                        txtUsuario.Focus();
                    }
                    mysqlcon.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    MessageBox.Show("Error al conectar con la Base de Datos. Si el error persiste, contacte a soporte (tel: 965002727)");

                }
            }
        }

        private void linkContrasena_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_ForgotPassword form_ForgotPassword = new Form_ForgotPassword();
            form_ForgotPassword.Show();
        }
    }
}
