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
    public partial class Productos : Form
    {
        string connectionString = "server = 35.198.31.209; user = tpvllanq; database = tpvllanquihueDB; port = 3306; password = 18653129a; SslMode=none";
        long id = 0;
        string rut;
        int inicio = 0;

        public Productos(string rut)
        {
            InitializeComponent();
            this.rut = rut;
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connectionString))
            {
                Console.WriteLine(id);
                mysqlcon.Open();
                MySqlCommand mysqlcmd = new MySqlCommand("AddOrEditProducto", mysqlcon);
                mysqlcmd.CommandType = CommandType.StoredProcedure;
                mysqlcmd.Parameters.AddWithValue("_id", id);
                mysqlcmd.Parameters.AddWithValue("_descripcion", txtDescripcion.Text.Trim());
                mysqlcmd.Parameters.AddWithValue("_categoria", txtCategoria.Text.Trim());
                mysqlcmd.Parameters.AddWithValue("_proveedor", cbProveedor.Text);
                mysqlcmd.Parameters.AddWithValue("_precio", txtPrecio.Text.Trim());
                mysqlcmd.Parameters.AddWithValue("_stock", txtStock.Text.Trim());
                mysqlcmd.Parameters.AddWithValue("_codigo", Convert.ToInt64(txtCodigo.Text.Trim()));
                mysqlcmd.Parameters.AddWithValue("_rut", this.rut);
                mysqlcmd.ExecuteNonQuery();
                clear();
                MessageBox.Show("Ingresado Correctamente");
                fillGrid();
                fillCBProveedores();
            }
        }

        private void fillGrid()
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connectionString))
            {
                mysqlcon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("ViewAllProducto", mysqlcon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_inicio", inicio);
                DataTable dataTableProductos = new DataTable();
                sqlDa.Fill(dataTableProductos);
                dgvProductos.DataSource = dataTableProductos;
                dgvProductos.Columns[6].Visible = false;
            }
        }

        private void Productos_Load_1(object sender, EventArgs e)
        {
            clear();
            fillGrid();
            fillCBProveedores();
        }

        private void fillCBProveedores()
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connectionString))
            {
                mysqlcon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("getAllNameProveedor", mysqlcon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet dataSetProveedores = new DataSet();
                sqlDa.Fill(dataSetProveedores);
                cbProveedor.DataSource = dataSetProveedores.Tables[0];
                cbProveedor.DisplayMember = "nombre";
            }
        }

        void clear()
        {
            txtCategoria.Text = txtCodigo.Text = txtDescripcion.Text = txtPrecio.Text = txtStock.Text = "";
            cbProveedor.Text = "";
            id = 0;
            btnGuardar.Text = "Guardar";
            btnDescontinuar.Enabled = false;
        }


        private void dgvProductos_DoubleClick(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow.Index != -1)
            {
                txtCodigo.Text = dgvProductos.CurrentRow.Cells[0].Value.ToString();
                txtDescripcion.Text = dgvProductos.CurrentRow.Cells[1].Value.ToString();
                txtCategoria.Text = dgvProductos.CurrentRow.Cells[2].Value.ToString();
                cbProveedor.Text = dgvProductos.CurrentRow.Cells[4].Value.ToString();
                txtPrecio.Text = dgvProductos.CurrentRow.Cells[3].Value.ToString();
                txtStock.Text = dgvProductos.CurrentRow.Cells[5].Value.ToString();
                id = Convert.ToInt64(dgvProductos.CurrentRow.Cells[0].Value.ToString());
                btnGuardar.Text = "Actualizar";
                btnDescontinuar.Enabled = true;
            }
        }

        private void btnDescontinuar_Click_1(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connectionString))
            {
                mysqlcon.Open();
                MySqlCommand mysqlcmd = new MySqlCommand("EditStateProducto", mysqlcon);
                mysqlcmd.CommandType = CommandType.StoredProcedure;
                mysqlcmd.Parameters.AddWithValue("_codigo", Convert.ToInt64(txtCodigo.Text));
                mysqlcmd.ExecuteNonQuery();
                clear();
                MessageBox.Show("Eliminado Correctamente");
                fillGrid();
                fillCBProveedores();
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            inicio = inicio + 25;
            fillGrid();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            if (inicio != 0)
            {
                inicio = inicio - 25;
                fillGrid();
            }
        }

        private void txtBuscarProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                inicio = 0;
                using (MySqlConnection mysqlcon = new MySqlConnection(connectionString))
                {
                    mysqlcon.Open();
                    MySqlDataAdapter sqlDa = new MySqlDataAdapter("SearchByValueProducto", mysqlcon);
                    sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sqlDa.SelectCommand.Parameters.AddWithValue("_SearchValue", txtBuscarProducto.Text);
                    sqlDa.SelectCommand.Parameters.AddWithValue("_inicio", inicio);
                    DataTable dataTableProveedores = new DataTable();
                    sqlDa.Fill(dataTableProveedores);
                    dgvProductos.DataSource = dataTableProveedores;
                    dgvProductos.Columns[6].Visible = false;
                }
            }
        }
    }
}
