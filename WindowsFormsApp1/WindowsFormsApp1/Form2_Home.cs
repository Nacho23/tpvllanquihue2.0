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
using System.Globalization;

namespace WindowsFormsApp1
{
    public partial class Inicio : Form
    {
        string connectionString = "server = localhost; user = root; database = mydb; port = 3306; password = 1234; SslMode=none";

        public Inicio()
        {
            InitializeComponent();
        }

        private void horaFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text = DateTime.Now.ToString("dd-MMMM-yyyy");
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connectionString))
            {
                mysqlcon.Open();
                MySqlCommand mysqlcmd = new MySqlCommand("getNumProveedores", mysqlcon);
                mysqlcmd.CommandType = CommandType.StoredProcedure;
                MySqlDataReader result = mysqlcmd.ExecuteReader();
                if (result.Read())
                {
                    if (result.IsDBNull(0))
                    {
                        lbProveedores.Text = "0";
                    }
                    else
                    {
                        lbProveedores.Text = result.GetInt32(0).ToString();
                    }
                } 
                mysqlcon.Close();

                mysqlcon.Open();
                MySqlCommand mysqlcmdPr = new MySqlCommand("getNumProductos", mysqlcon);
                mysqlcmdPr.CommandType = CommandType.StoredProcedure;
                MySqlDataReader resultPr = mysqlcmdPr.ExecuteReader();
                if (resultPr.Read())
                {
                    if (resultPr.IsDBNull(0))
                    {
                        lbProductos.Text = "0";
                    }
                    else
                    {
                        lbProductos.Text = resultPr.GetInt32(0).ToString();
                    }
                }
                
                mysqlcon.Close();

                mysqlcon.Open();
                MySqlCommand mysqlcmdV = new MySqlCommand("getNumVentas", mysqlcon);
                mysqlcmdV.CommandType = CommandType.StoredProcedure;
                MySqlDataReader resultV = mysqlcmdV.ExecuteReader();
                if (resultV.Read())
                {
                    if (resultV.IsDBNull(0))
                    {
                        lbVentas.Text = "0";
                    }
                    else
                    {
                        lbVentas.Text = resultV.GetInt32(0).ToString();
                    }
                }
                
                mysqlcon.Close();


                string mes = DateTime.Now.ToString("MM");
                Console.WriteLine(mes);
                mysqlcon.Open();
                MySqlCommand mysqlcmdI = new MySqlCommand("getGananciaMes", mysqlcon);
                mysqlcmdI.CommandType = CommandType.StoredProcedure;
                mysqlcmdI.Parameters.AddWithValue("_solicitud", "ingreso");
                mysqlcmdI.Parameters.AddWithValue("_mes", mes);
                mysqlcmdI.Parameters.AddWithValue("_dia", "");
                mysqlcmdI.Parameters.AddWithValue("_proveedor", "");
                MySqlDataReader resultI = mysqlcmdI.ExecuteReader();
                if (resultI.Read())
                {
                    if (resultI.IsDBNull(0))
                    {
                        lbIngresos.Text = "0";
                    }
                    else
                    {
                        CultureInfo cl = new CultureInfo("es-CL");
                        lbIngresos.Text = resultI.GetInt32(0).ToString("C", cl);
                    }
                }
                
                mysqlcon.Close();
            }

            fillLowStockProducts();
        }

        private void lbProveedores_Click(object sender, EventArgs e)
        {

        }

        private void lbVentas_Click(object sender, EventArgs e)
        {

        }

        private void lbIngresos_Click(object sender, EventArgs e)
        {

        }

        private void lbProductos_Click(object sender, EventArgs e)
        {

        }

        private void fillLowStockProducts()
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connectionString))
            {
                mysqlcon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("getLowStock", mysqlcon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dataTableProductos = new DataTable();
                sqlDa.Fill(dataTableProductos);
                dgvStockBajo.DataSource = dataTableProductos;
            }
        }
    }
}
