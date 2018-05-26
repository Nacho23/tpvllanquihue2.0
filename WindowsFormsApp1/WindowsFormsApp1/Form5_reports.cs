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
    public partial class Reportes : Form
    {
        string connectionString = "server = localhost; user = root; database = mydb; port = 3306; password = 1234; SslMode=none";

        public Reportes()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbPeriodo.Text = cbPeriodo.Text;
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connectionString))
            {
                string mes = DateTime.Now.ToString("MM");
                lbPeriodo.Text = DateTime.Now.ToString("MMMM");
                cbPeriodo.SelectedText = DateTime.Now.ToString("MMMM");
                Console.WriteLine(mes);
                mysqlcon.Open();
                MySqlCommand mysqlcmdI = new MySqlCommand("getIngresosMes", mysqlcon);
                mysqlcmdI.CommandType = CommandType.StoredProcedure;
                mysqlcmdI.Parameters.AddWithValue("_mes", mes);
                MySqlDataReader resultI = mysqlcmdI.ExecuteReader();
                if (resultI.Read())
                {
                    CultureInfo cl = new CultureInfo("es-CL");
                    lbTotalIngresos.Text = resultI.GetInt32(0).ToString("C", cl);
                }
                mysqlcon.Close();

                mysqlcon.Open();
                MySqlCommand mysqlcmd2 = new MySqlCommand("getGananciaMes", mysqlcon);
                mysqlcmd2.CommandType = CommandType.StoredProcedure;
                mysqlcmd2.Parameters.AddWithValue("_mes", mes);
                MySqlDataReader result2 = mysqlcmd2.ExecuteReader();
                if (result2.Read())
                {
                    CultureInfo cl = new CultureInfo("es-CL");
                    lbGanancia.Text = result2.GetInt32(0).ToString("C", cl);
                }
                mysqlcon.Close();
            }
        }
    }
}
