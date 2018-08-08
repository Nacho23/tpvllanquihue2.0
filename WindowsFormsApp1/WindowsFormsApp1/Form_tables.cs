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
    public partial class Form_tables : Form
    {
        string connectionString = "server = 35.198.31.209; user = tpvllanq; database = tpvllanquihueDB; port = 3306; password = 18653129a; SslMode=none";
        string valor;

        public Form_tables(string valor)
        {
            InitializeComponent();
            this.valor = valor;
            if (valor == "Ingresos")
            {
                cargaTablaIngresos();
            }
            else
            {
                cargaTablaModificaciones();
            }
        }

        private void cargaTablaModificaciones()
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connectionString))
            {
                mysqlcon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("getRegister", mysqlcon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_valor", this.valor);
                DataTable dataTableRegistro = new DataTable();
                sqlDa.Fill(dataTableRegistro);
                dgvRegister.DataSource = dataTableRegistro;
                //dgvRegister.Columns[6].Visible = false;
            }
        }

        private void cargaTablaIngresos()
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connectionString))
            {
                mysqlcon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("getRegister", mysqlcon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_valor", this.valor);
                DataTable dataTableRegistro = new DataTable();
                sqlDa.Fill(dataTableRegistro);
                dgvRegister.DataSource = dataTableRegistro;
                //dgvRegister.Columns[6].Visible = false;
            }
        }
    }
}
