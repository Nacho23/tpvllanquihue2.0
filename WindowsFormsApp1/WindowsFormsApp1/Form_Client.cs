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
    public partial class Cliente : Form
    {
        string connectionString = "server = 35.198.31.209; user = tpvllanq; database = tpvllanquihueDB; port = 3306; password = 18653129a; SslMode=none";

        public Cliente()
        {
            InitializeComponent();
            fillGrid();
        }

        private void fillGrid()
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connectionString))
            {
                mysqlcon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("getClientData", mysqlcon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_id", txtSearchClient.Text);
                DataTable dataTableClientes = new DataTable();
                sqlDa.Fill(dataTableClientes);
                dgvClients.DataSource = dataTableClientes;
                //dgvClients.Columns[6].Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                fillGrid();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_AddClient form_AddClient = new Form_AddClient();
            form_AddClient.ShowDialog();
            fillGrid();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            Form_Abonar form_Abonar = new Form_Abonar(txtRut.Text, txtDeuda.Text);
            form_Abonar.ShowDialog();
            fillGrid();
        }

        private void dgvClients_Click(object sender, EventArgs e)
        {
            if (dgvClients.CurrentRow.Index != -1)
            {
                txtRut.Text = dgvClients.CurrentRow.Cells[0].Value.ToString();
                txtName.Text = dgvClients.CurrentRow.Cells[1].Value.ToString();
                txtDeuda.Text = dgvClients.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Form_AddClient form_AddClient = new Form_AddClient(txtRut.Text);
            form_AddClient.ShowDialog();
            fillGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
