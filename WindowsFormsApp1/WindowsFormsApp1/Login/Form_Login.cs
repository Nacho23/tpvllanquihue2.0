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
using WindowsFormsApp1.Login;

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
            login(e);
        }

        private void login(EventArgs e)
        {
            if (Controller_Login.loginUser(txtUsuario.Text, txtContrasena.Text))
            {
                this.Hide();
                Controller_Login.registerSession(txtUsuario.Text);
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
        }

        private void linkContrasena_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_ForgotPassword form_ForgotPassword = new Form_ForgotPassword();
            form_ForgotPassword.Show();
        }

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                login(e);
            }
        }
    }
}
