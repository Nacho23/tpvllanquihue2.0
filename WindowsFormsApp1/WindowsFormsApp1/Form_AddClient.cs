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
    public partial class Form_AddClient : Form
    {
        string connectionString = "server = 35.198.31.209; user = tpvllanq; database = tpvllanquihueDB; port = 3306; password = 18653129a; SslMode=none";
        string rut;
        //string nombre, fecha_nac, sexo, telefono, direccion, email, observaciones = "";

        private void Form_AddClient_Load(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connectionString))
            {
                mysqlcon.Open();
                MySqlCommand mysqlcmd = new MySqlCommand("getClientByRut", mysqlcon);
                mysqlcmd.CommandType = CommandType.StoredProcedure;
                mysqlcmd.Parameters.AddWithValue("_rut", txtRut.Text);
                MySqlDataReader result = mysqlcmd.ExecuteReader();
                if (result.Read())
                {
                    txtName.Text = result[1].ToString();
                    dtpBirthdate.Text = result[2].ToString();
                    cbSex.Text = result[3].ToString();
                    txtPhone.Text = result[4].ToString();
                    txtAddress.Text = result[5].ToString();
                    txtEmail.Text = result[6].ToString();
                    txtObservations.Text = result[7].ToString();
                }
                else
                {
                    Console.WriteLine("No carga nada");
                }

                mysqlcon.Close();
            }
        }

        public Form_AddClient(string rut)
        {
            InitializeComponent();
            txtRut.Text = rut;
            this.rut = rut;
        }

        public Form_AddClient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            registerClient();
        }

        private void registerClient()
        {
            string fecha_mod = dtpBirthdate.Text.Substring(6, 4) + dtpBirthdate.Text.Substring(3, 2) + dtpBirthdate.Text.Substring(0, 2);

            using (MySqlConnection mysqlcon = new MySqlConnection(connectionString))
            {
                mysqlcon.Open();
                MySqlCommand mysqlcmd = new MySqlCommand("AddOrEditClient", mysqlcon);
                mysqlcmd.CommandType = CommandType.StoredProcedure;
                mysqlcmd.Parameters.AddWithValue("_rut", txtRut.Text.Trim());
                mysqlcmd.Parameters.AddWithValue("_nombre", txtName.Text.Trim());
                mysqlcmd.Parameters.AddWithValue("_fecha_nac", fecha_mod);
                mysqlcmd.Parameters.AddWithValue("_sexo", cbSex.Text);
                mysqlcmd.Parameters.AddWithValue("_telefono", txtPhone.Text.Trim());
                mysqlcmd.Parameters.AddWithValue("_direccion", txtAddress.Text.Trim());
                mysqlcmd.Parameters.AddWithValue("_email", txtEmail.Text.Trim());
                mysqlcmd.Parameters.AddWithValue("_observaciones", txtObservations.Text.Trim());
                mysqlcmd.ExecuteNonQuery();
                MessageBox.Show("Registrado Correctamente");

                mysqlcon.Close();
            }

            this.Close();
        }

        /*private void addClientSale(string rut)
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connectionString))
            {
                int _id_venta = 0;

                mysqlcon.Open();
                MySqlCommand mysqlcmd2 = new MySqlCommand("getMaxIdVentas", mysqlcon);
                mysqlcmd2.CommandType = CommandType.StoredProcedure;
                MySqlDataReader result2 = mysqlcmd2.ExecuteReader();
                if (result2.Read())
                {
                    if (result2.IsDBNull(0))
                    {
                        MessageBox.Show("No existe registro en la BD");
                    }
                    else
                    {
                        _id_venta = result2.GetInt32(0);
                        mysqlcon.Close();

                        mysqlcon.Open();

                        MySqlCommand mysqlcmd = new MySqlCommand("insertClientSale", mysqlcon);
                        mysqlcmd.CommandType = CommandType.StoredProcedure;
                        mysqlcmd.Parameters.AddWithValue("_rut", rut);
                        mysqlcmd.Parameters.AddWithValue("_id_venta", _id_venta);
                        mysqlcmd.ExecuteNonQuery();

                        mysqlcon.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Error en la consulta a la BD");
                }
            }
        }*/
    }
}
