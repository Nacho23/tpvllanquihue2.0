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
    public partial class Form_Registro_Ventas : Form
    {
        string connectionString = "server = localhost; user = root; database = mydb; port = 3306; password = 1234; SslMode=none";
        DataTable dataTableResult = new DataTable();

        public Form_Registro_Ventas()
        {
            InitializeComponent();
            fillGrid();
        }

        private void fillGrid()
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connectionString))
            {
                int [] cantidad_ventas;

                //OBTIENE TOTAL DE VENTAS
                mysqlcon.Open();
                MySqlCommand mysqlcmd = new MySqlCommand("getNumVentas", mysqlcon);
                mysqlcmd.CommandType = CommandType.StoredProcedure;
                MySqlDataReader result = mysqlcmd.ExecuteReader();
                if (result.Read())
                {
                    if (result.IsDBNull(0))
                    {
                        Console.WriteLine("Error en la Conexion");
                    }
                    else
                    {
                        cantidad_ventas = new int[result.GetInt32(0)];
                        mysqlcon.Close();

                        //RETORNA UNA LISTA DE TODAS LAS VENTAS
                        mysqlcon.Open();
                        MySqlCommand mysqlcmd1 = new MySqlCommand("getIdsVenta", mysqlcon);
                        mysqlcmd1.CommandType = CommandType.StoredProcedure;
                        MySqlDataReader result1 = mysqlcmd1.ExecuteReader();
                        if (result1.HasRows)
                        {
                            int i = 0;
                            while (result1.Read())
                            {
                                cantidad_ventas[i] = result1.GetInt32(0);
                                i++;
                            }
                        }
                        mysqlcon.Close();

                        
                        dataTableResult.Columns.Add("id Venta");
                        dataTableResult.Columns.Add("Ingreso Total");
                        dataTableResult.Columns.Add("Ganancia");
                        dataTableResult.Columns.Add("Fecha");
                        dataTableResult.Columns.Add("Hecha por");
                        for (int i = 0; i < cantidad_ventas.Length; i++) {
                            mysqlcon.Open();
                            MySqlCommand mysqlcmd2 = new MySqlCommand("getVentaConTotales", mysqlcon);
                            mysqlcmd2.CommandType = CommandType.StoredProcedure;
                            mysqlcmd2.Parameters.AddWithValue("_id", cantidad_ventas[i]);
                            MySqlDataReader result2 = mysqlcmd2.ExecuteReader();
                            if (result2.Read())
                            {
                                
                                if (result2.IsDBNull(0))
                                {
                                    Console.WriteLine("Error en la conexion");
                                }
                                else
                                {
                                    try { 
                                        CultureInfo cl = new CultureInfo("es-CL");
                                        string [] fila = new string[5];
                                        fila[0] = result2.GetString(0);
                                        fila[1] = result2.GetInt32(3).ToString("C", cl);
                                        fila[2] = result2.GetInt32(4).ToString("C", cl);
                                        fila[3] = result2.GetDateTime(1).ToString();
                                        fila[4] = result2.GetString(2);
                                        dataTableResult.Rows.Add(fila);
                                    }
                                    catch(Exception e)
                                    {
                                        Console.WriteLine(e);
                                    }
                                }
                                mysqlcon.Close();
                            }
                        }
                        dgvRegistroVentas.DataSource = dataTableResult;                        
                    }
                }
            }
        }


        private void dgvRegistroVentas_DoubleClick(object sender, EventArgs e)
        {
            if (dgvRegistroVentas.CurrentRow.Index != -1)
            {
                txtCodVenta.Text = dgvRegistroVentas.CurrentRow.Cells[0].Value.ToString();
                txtIngresoTotal.Text = dgvRegistroVentas.CurrentRow.Cells[1].Value.ToString();
                txtGanancia.Text = dgvRegistroVentas.CurrentRow.Cells[2].Value.ToString();
                txtFecha.Text = dgvRegistroVentas.CurrentRow.Cells[3].Value.ToString();
                txtVendidaPor.Text = dgvRegistroVentas.CurrentRow.Cells[4].Value.ToString();
            }
        }

        private void txtBuscarVenta_TextChanged(object sender, EventArgs e)
        {
            /*if (txtBuscarVenta.Text == "")
            {
                dgvRegistroVentas.DataSource = dataTableResult;
                return;
            }

            string busqueda = txtBuscarVenta.Text;

            //Con LinQ buscamos las rows que coincidan
            try
            {
                DataTable df = (from item in dataTableResult.Rows.Cast<DataRow>()
                                let codigo = Convert.ToString(item[0] == null ? string.Empty : item[0].ToString() )
                                where codigo.Contains(busqueda)
                                select item).CopyToDataTable();
                dgvRegistroVentas.DataSource = df;
            }
            catch
            {
                MessageBox.Show("No se encontraron registros");
                txtBuscarVenta.Focus();
            }*/
        }

        Bitmap bmp;

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            int alto = dgvRegistroVentas.Height;
            dgvRegistroVentas.Height = dgvRegistroVentas.RowCount * dgvRegistroVentas.RowTemplate.Height * 2;
            bmp = new Bitmap(dgvRegistroVentas.Width, dgvRegistroVentas.Height);
            dgvRegistroVentas.DrawToBitmap(bmp, new Rectangle(0, 0, dgvRegistroVentas.Width, dgvRegistroVentas.Height));
            dgvRegistroVentas.Height = alto;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
