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
    public partial class Compras : Form
    {
        string connectionString = "server = 35.198.31.209; user = tpvllanq; database = tpvllanquihueDB; port = 3306; password = 18653129a; SslMode=none";
        int id = 0;
        string rut;

        public Compras(string rut)
        {
            InitializeComponent();
            this.rut = rut;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connectionString))
            {
                mysqlcon.Open();
                MySqlCommand mysqlcmd = new MySqlCommand("AddOrEditProveedor", mysqlcon);
                mysqlcmd.CommandType = CommandType.StoredProcedure;
                mysqlcmd.Parameters.AddWithValue("_id", id);
                mysqlcmd.Parameters.AddWithValue("_nombre", txtNombre.Text.Trim());
                mysqlcmd.Parameters.AddWithValue("_direccion", txtDireccion.Text.Trim());
                mysqlcmd.Parameters.AddWithValue("_telefono", txtTelefono.Text.Trim());
                mysqlcmd.Parameters.AddWithValue("_email", txtEmail.Text.Trim());
                mysqlcmd.Parameters.AddWithValue("_ganancia", txtGanancia.Text.Trim());
                mysqlcmd.Parameters.AddWithValue("_rut", this.rut);
                mysqlcmd.ExecuteNonQuery();
                clear();
                MessageBox.Show("Ingresado Correctamente");
                fillGrid();
            }
        }

        private void fillGrid()
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connectionString))
            {
                mysqlcon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("ViewAllProveedor", mysqlcon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dataTableProveedores = new DataTable();
                sqlDa.Fill(dataTableProveedores);
                dgvProveedor.DataSource = dataTableProveedores;
                dgvProveedor.Columns[0].Visible = false;
                dgvProveedor.Columns[5].Visible = false;
            }
        }

        private void Compras_Load(object sender, EventArgs e)
        {
            clear();
            fillGrid();
        }

        void clear()
        {
            txtDireccion.Text = txtEmail.Text = txtNombre.Text = txtTelefono.Text = "";
            id = 0;
            btnGuardar.Text = "Guardar";
            btnBorrar.Enabled = false;
        }
        
        private void dgvProveedor_DoubleClick(object sender, EventArgs e)
        {
            if(dgvProveedor.CurrentRow.Index != -1)
            {
                txtNombre.Text = dgvProveedor.CurrentRow.Cells[1].Value.ToString();
                txtDireccion.Text = dgvProveedor.CurrentRow.Cells[2].Value.ToString();
                txtTelefono.Text = dgvProveedor.CurrentRow.Cells[3].Value.ToString();
                txtEmail.Text = dgvProveedor.CurrentRow.Cells[4].Value.ToString();
                txtGanancia.Text = dgvProveedor.CurrentRow.Cells[6].Value.ToString();
                id = Convert.ToInt32(dgvProveedor.CurrentRow.Cells[0].Value.ToString());
                btnGuardar.Text = "Actualizar";
                btnBorrar.Enabled = true;
            }
        }

        private void txtBuscarProveedor_TextChanged(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connectionString))
            {
                mysqlcon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("SearchByValueProveedor", mysqlcon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_SearchValue", txtBuscarProveedor.Text);
                DataTable dataTableProveedores = new DataTable();
                sqlDa.Fill(dataTableProveedores);
                dgvProveedor.DataSource = dataTableProveedores;
                dgvProveedor.Columns[0].Visible = false;
                dgvProveedor.Columns[5].Visible = false;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connectionString))
            {
                mysqlcon.Open();
                MySqlCommand mysqlcmd = new MySqlCommand("DeleteByIdProveedor", mysqlcon);
                mysqlcmd.CommandType = CommandType.StoredProcedure;
                mysqlcmd.Parameters.AddWithValue("_id", id);
                mysqlcmd.ExecuteNonQuery();
                clear();
                MessageBox.Show("Eliminado Correctamente");
                fillGrid();
            }
        }
    }
}
