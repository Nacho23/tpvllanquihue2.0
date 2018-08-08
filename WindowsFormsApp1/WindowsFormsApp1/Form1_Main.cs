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
    public partial class Form1_Main : Form
    {
        public Form1_Main(string rut)
        {
            InitializeComponent();
            abrirFormularioHijo(new Inicio());
            setUserLabels(rut);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.btnInicio_Click(null, e);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWind, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCloseDown_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void abrirFormularioHijo(object formuHijo)
        {
            if(this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formuHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new Productos(lbRut.Text));
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new Inicio());
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new Ventas(lbRut.Text));
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new Compras(lbRut.Text));
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new Reportes());
        }

        private void btnInicio2_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new Inicio());
        }

        private void setUserLabels(string rut)
        {
            string connectionString = "server = 35.198.31.209; user = tpvllanq; database = tpvllanquihueDB; port = 3306; password = 18653129a; SslMode=none";

            using (MySqlConnection mysqlcon = new MySqlConnection(connectionString))
            {
                mysqlcon.Open();
                MySqlCommand mysqlcmd = new MySqlCommand("getUserByRut", mysqlcon);
                mysqlcmd.Parameters.AddWithValue("_rut", rut);
                mysqlcmd.CommandType = CommandType.StoredProcedure;
                MySqlDataReader result = mysqlcmd.ExecuteReader();
                if (result.Read())
                {
                    lbName.Text = result.GetString(1).ToString();
                    lbRut.Text = result.GetString(0).ToString();
                }
                mysqlcon.Close();
            }
        }

        private void btnPerfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            abrirFormularioHijo(new Perfil(lbRut.Text));
        }

        private void btnRegistroVentas_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new Form_Registro_Ventas());
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new Cliente());
        }
    }
}
