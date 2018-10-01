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
using WindowsFormsApp1.AddClient;

namespace WindowsFormsApp1
{
    public partial class Form_AddClient : Form
    {
        string rut;

        private void Form_AddClient_Load(object sender, EventArgs e)
        {
            string[] data = Controller_AddClient.getClientByRut(txtRut.Text);

            txtName.Text = data[0];
            dtpBirthdate.Text = data[1];
            cbSex.Text = data[2];
            txtPhone.Text = data[3];
            txtAddress.Text = data[4];
            txtEmail.Text = data[5];
            txtObservations.Text = data[6];
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

            Controller_AddClient.addOrEditClient(
                txtRut.Text.Trim(),
                txtName.Text.Trim(),
                fecha_mod,
                cbSex.Text,
                txtPhone.Text.Trim(),
                txtAddress.Text.Trim(),
                txtEmail.Text.Trim(),
                txtObservations.Text.Trim());

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
