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

namespace WindowsFormsApp1
{
    public partial class Perfil : Form
    {
        string connectionString = "server = localhost; user = root; database = mydb; port = 3306; password = 1234; SslMode=none";
        string rut = "";

        public Perfil(string rut)
        {
            InitializeComponent();
            this.rut = rut;
        }

        public void cargarDatos(string rut)
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connectionString))
            {
                mysqlcon.Open();
                MySqlCommand mysqlcmd = new MySqlCommand("getUserByRut", mysqlcon);
                mysqlcmd.Parameters.AddWithValue("_rut", rut);
                mysqlcmd.CommandType = CommandType.StoredProcedure;
                MySqlDataReader result = mysqlcmd.ExecuteReader();
                DataTable dataTableProductos = new DataTable();
                if (result.Read())
                {
                    txtNombre.Text = result.GetString(1).ToString();
                    txtRut.Text = result.GetString(0).ToString();
                    txtApellido.Text = result.GetString(2).ToString();
                    txtEmail.Text = result.GetString(3).ToString();
                }
                mysqlcon.Close();
                btnModDatos.Enabled = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Perfil_Load(object sender, EventArgs e)
        {
            cargarDatos(rut);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCambiarContrasena_Click(object sender, EventArgs e)
        {
            if(txtContrasenaActual.Text != "" && txtContrasenaNueva.Text != "" && txtConfirmaContrasena.Text != "")
            {
                using (MySqlConnection mysqlcon = new MySqlConnection(connectionString))
                {
                    mysqlcon.Open();
                    MySqlCommand mysqlcmd = new MySqlCommand("getAccountByRut", mysqlcon);
                    mysqlcmd.Parameters.AddWithValue("_rut", txtRut.Text);
                    mysqlcmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataReader result = mysqlcmd.ExecuteReader();
                    if (result.Read())
                    {
                        Console.WriteLine(result.GetString(0).ToString());
                        if (txtContrasenaActual.Text == result.GetString(0).ToString())
                        {
                            mysqlcon.Close();
                            if (txtContrasenaNueva.Text == txtConfirmaContrasena.Text)
                            {
                                mysqlcon.Open();
                                MySqlCommand mySqlCommand = new MySqlCommand("changePass", mysqlcon);
                                mySqlCommand.CommandType = CommandType.StoredProcedure;
                                mySqlCommand.Parameters.AddWithValue("_rut", txtRut.Text);
                                mySqlCommand.Parameters.AddWithValue("_contrasena", txtContrasenaNueva.Text);
                                mySqlCommand.ExecuteNonQuery();
                                MessageBox.Show("Contraseña cambiada exitosamente");
                                mysqlcon.Close();
                            } else
                            {
                                lbMensaje.Text = "Las contraseñas no coinciden, Intente Nuevamente";
                                lbMensaje.Visible = true;
                                txtContrasenaNueva.Text = "";
                                txtConfirmaContrasena.Text = "";
                                txtContrasenaNueva.Focus();
                            }
                        }
                        else
                        {
                            lbMensaje.Text = "Contraseña Incorrecta, Intente Nuevamente";
                            lbMensaje.Visible = true;
                            txtContrasenaActual.Text = "";
                            txtContrasenaActual.Focus();
                        }
                    }
                    else
                    {
                        lbMensaje.Text = "Problemas con la conexión, Intente Nuevamente";
                        lbMensaje.Visible = true;
                    }
                }
            } else
            {
                lbMensaje.Text = "Existen Campos en Blanco";
                lbMensaje.Visible = true;
            }
        }

        private void btnModDatos_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connectionString))
            {
                mysqlcon.Open();
                MySqlCommand mysqlcmd = new MySqlCommand("changeUserData", mysqlcon);
                mysqlcmd.Parameters.AddWithValue("_rut", txtRut.Text);
                mysqlcmd.Parameters.AddWithValue("_nombre", txtNombre.Text);
                mysqlcmd.Parameters.AddWithValue("_apellido_p", txtApellido.Text);
                mysqlcmd.Parameters.AddWithValue("_email", txtEmail.Text);
                mysqlcmd.CommandType = CommandType.StoredProcedure;
                mysqlcmd.ExecuteNonQuery();
                MessageBox.Show("Información Modificada Correctamente");
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            btnModDatos.Enabled = true;
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            btnModDatos.Enabled = true;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            btnModDatos.Enabled = true;
        }
    }
}
