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
using WindowsFormsApp1.Home;

namespace WindowsFormsApp1
{
    public partial class Inicio : Form
    {
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
            load_proveedores();
            load_numProductos();
            load_numVentas();
            load_gananciaMes();

            fillLowStockProducts();
        }
        private void load_proveedores()
        {
            lbProveedores.Text = Controller_Home.getNumProveedores();
        }
        private void load_numProductos()
        {
            lbProductos.Text = Controller_Home.getNumProductos();
        }
        private void load_numVentas()
        {
            lbVentas.Text = Controller_Home.getNumVentas();
        }
        private void load_gananciaMes()
        {
            lbIngresos.Text = Controller_Home.getGananciaMes();
        }
        private void fillLowStockProducts()
        {
            dgvStockBajo.DataSource = Controller_Home.getLowStockTable();
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
    }
}
