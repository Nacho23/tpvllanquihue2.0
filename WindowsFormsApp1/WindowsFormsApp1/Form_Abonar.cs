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
    public partial class Form_Abonar : Form
    {
        string monto, rut;
        string connectionString = "server = localhost; user = root; database = mydb; port = 3306; password = 1234; SslMode=none";


        public Form_Abonar(string rut, string monto)
        {
            InitializeComponent();
            lblDeuda.Text = monto;
            this.monto = monto;
            this.rut = rut;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtAbono_TextChanged(object sender, EventArgs e)
        {
            int deuda_nueva;
            if (txtAbono.Text == "")
            {
                lblDeuda.Text = monto;
            } else
            {
                deuda_nueva = Convert.ToInt32(monto) - Convert.ToInt32(txtAbono.Text);
                if(deuda_nueva < 0)
                {
                    MessageBox.Show("El pago supera a la deuda");
                    txtAbono.Text = "";
                    txtAbono.Focus();
                } else
                {
                    lblDeuda.Text = deuda_nueva.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAbonar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connectionString))
            {
                mysqlcon.Open();
                MySqlCommand mysqlcmd = new MySqlCommand("updateDebt", mysqlcon);
                mysqlcmd.CommandType = CommandType.StoredProcedure;
                Console.WriteLine(lblDeuda.Text);
                mysqlcmd.Parameters.AddWithValue("_rut", this.rut);
                mysqlcmd.Parameters.AddWithValue("_deuda", lblDeuda.Text);
                mysqlcmd.ExecuteNonQuery();

                mysqlcon.Close();
            }

            this.Hide();
        }
    }
}
