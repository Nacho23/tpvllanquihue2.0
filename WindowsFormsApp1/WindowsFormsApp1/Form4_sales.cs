using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Ventas : Form
    {
        string connectionString = "server = 35.198.31.209; user = tpvllanq; database = tpvllanquihueDB; port = 3306; password = 18653129a; SslMode=none";
        List<ProductoVenta> listaVentas = new List<ProductoVenta>();
        string rut;

        public Ventas(string rut)
        {
            InitializeComponent();
            inicializaTabla();
            this.rut = rut;
        }

        private void txtCantidad_Enter(object sender, EventArgs e)
        {
            txtCantidad.Text = "";
        }

        private void txtIngresoProducto_Leave(object sender, EventArgs e)
        {
            if (txtIngresoProducto.Text == "")
            {
                txtIngresoProducto.Text = "Buscar Producto";
                txtIngresoProducto.ForeColor = Color.DimGray;
            }
        }

        private void txtIngresoProducto_Enter(object sender, EventArgs e)
        {
            if (txtIngresoProducto.Text == "Buscar Producto")
            {
                txtIngresoProducto.Text = "";
                txtIngresoProducto.ForeColor = Color.Black;
            }
        }

        private void txtIngresoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtCantidad.Text.Trim() != "" && txtIngresoProducto.Text.Trim() != "")
                {
                    using (MySqlConnection mysqlcon = new MySqlConnection(connectionString))
                    {
                        mysqlcon.Open();
                        MySqlCommand mysqlcmd = new MySqlCommand("SearchProductByCode", mysqlcon);
                        mysqlcmd.CommandType = CommandType.StoredProcedure;
                        mysqlcmd.Parameters.AddWithValue("_codigo", txtIngresoProducto.Text);
                        MySqlDataReader result = mysqlcmd.ExecuteReader();
                        if (result.Read())
                        {
                            if (Convert.ToInt32(result.GetString(5).ToString()) > 0)
                            {
                                txtDescripcion.Text = result.GetString(1).ToString();
                                txtCategoria.Text = result.GetString(2).ToString();
                                txtProveedor.Text = result.GetString(4).ToString();
                                txtPrecio.Text = result.GetString(3).ToString();

                                if (dgvVenta.Rows.Count != 0)
                                {
                                    bool seRepite = false;
                                    foreach (DataGridViewRow Row in dgvVenta.Rows)
                                    {
                                        string strFila = Row.Index.ToString();
                                        string valor = Convert.ToString(Row.Cells["Codigo"].Value);

                                        if (valor == txtIngresoProducto.Text)
                                        {
                                            seRepite = true;
                                        }
                                    }

                                    if (seRepite)
                                    {
                                        Console.WriteLine("SE REPITE");
                                        for (int i = 0; i < listaVentas.Count; i++)
                                        {
                                            if (txtIngresoProducto.Text == Convert.ToString(listaVentas[i].Codigo))
                                            {
                                                bool resultado = listaVentas[i].addProduct(Convert.ToInt32(txtCantidad.Text));
                                                if (!resultado)
                                                {
                                                    lbMensaje.Text = "Cantidad sobrepasa al Stock";
                                                    lbMensaje.Visible = true;
                                                    txtCantidad.Focus();
                                                }
                                                else
                                                {
                                                    lbMensaje.Visible = false;
                                                }
                                            }
                                        }
                                        inicializaTabla();
                                    }
                                    else
                                    {
                                        Console.WriteLine("NO SE REPITE");
                                        ProductoVenta productoVenta = new ProductoVenta();
                                        productoVenta.Descripcion = result.GetString(1).ToString();
                                        productoVenta.Categoria = result.GetString(2).ToString();
                                        productoVenta.Proveedor = result.GetString(4).ToString();
                                        productoVenta.Precio = Convert.ToInt32(result.GetString(3).ToString());
                                        productoVenta.Codigo = Convert.ToInt32(result.GetString(0).ToString());
                                        productoVenta.Cantidad = Convert.ToInt32(txtCantidad.Text);
                                        listaVentas.Add(productoVenta);
                                        inicializaTabla();
                                    }
                                }
                                else
                                {
                                    //Agregar a la LISTA
                                    ProductoVenta productoVenta = new ProductoVenta();
                                    productoVenta.Descripcion = result.GetString(1).ToString();
                                    productoVenta.Categoria = result.GetString(2).ToString();
                                    productoVenta.Proveedor = result.GetString(4).ToString();
                                    productoVenta.Precio = Convert.ToInt32(result.GetString(3).ToString());
                                    productoVenta.Codigo = Convert.ToInt32(result.GetString(0).ToString());
                                    productoVenta.Cantidad = Convert.ToInt32(txtCantidad.Text);
                                    listaVentas.Add(productoVenta);
                                    inicializaTabla();
                                }
                            } else
                            {                                
                                lbMensaje.Text = "No existe Stock";
                                lbMensaje.Visible = true;
                            }
                        }
                        mysqlcon.Close();
                    }
                    txtCantidad.Text = "1";
                    txtIngresoProducto.Text = "";
                    txtIngresoProducto.Focus();
                } else
                {
                    lbMensaje.Text = "Existen campos vacíos";
                    lbMensaje.Visible = true;
                }
            }
            txtIngresoProducto.Focus();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
            txtFecha.Text = fecha.Substring(0, 2) + "-" + fecha.Substring(3, 2) + "-" + fecha.Substring(6, 4);
            Console.WriteLine(txtFecha.Text);
            //num_ventas();
        }

        /*
        private void num_ventas()
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connectionString))
            {
                mysqlcon.Open();
                MySqlCommand mysqlcmdPr = new MySqlCommand("getNumVentas", mysqlcon);
                mysqlcmdPr.CommandType = CommandType.StoredProcedure;
                MySqlDataReader resultPr = mysqlcmdPr.ExecuteReader();
                if (resultPr.Read())
                {
                    txtCodVenta.Text = Convert.ToString(resultPr.GetInt32(0) + 1);
                }
                mysqlcon.Close();
            }
        }
        */

        public void inicializaTabla()
        {
            //num_ventas();

            DataTable dataTableProductos = new DataTable();

            DataColumn column;
            DataRow row;
            DataView view;

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Codigo";
            dataTableProductos.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Descripcion";
            dataTableProductos.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Categoria";
            dataTableProductos.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Proveedor";
            dataTableProductos.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.Int32");
            column.ColumnName = "Cantidad";
            dataTableProductos.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.Int32");
            column.ColumnName = "Importe";
            dataTableProductos.Columns.Add(column);

            //DESDE 0 AL LARGO DE LA LISTA POR DEFINIR
            for (int i = 0; i < listaVentas.Count; i++)
            {
                row = dataTableProductos.NewRow();
                row["Codigo"] = listaVentas[i].Codigo;
                row["Descripcion"] = listaVentas[i].Descripcion;
                row["Categoria"] = listaVentas[i].Categoria;
                row["Proveedor"] = listaVentas[i].Proveedor;
                row["Cantidad"] = listaVentas[i].Cantidad;
                row["Importe"] = listaVentas[i].Precio * listaVentas[i].Cantidad;
                dataTableProductos.Rows.Add(row);
            }

            view = new DataView(dataTableProductos);

            dgvVenta.DataSource = view;

            calculaTotal();
        }

        private void calculaTotal()
        {
            int total = 0;
            for (int i = 0; i < listaVentas.Count; i++)
            {
                total = total + (listaVentas[i].Cantidad * listaVentas[i].Precio);
            }
            lbTotal.Text = total.ToString();
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtIngresoProducto.Text == "")
                {
                    lbMensaje.Text = "Debe ingresar un codigo";
                    lbMensaje.Visible = true;
                    txtIngresoProducto.Focus();
                }
                else
                {
                    lbMensaje.Visible = false;
                    txtIngresoProducto_KeyPress(sender, e);
                }
            }
        }

        private void btnDisminuirCantidad_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listaVentas.Count; i++)
            {
                if (dgvVenta.SelectedRows[0].Cells[0].Value.ToString() == Convert.ToString(listaVentas[i].Codigo))
                {
                    int resultado = listaVentas[i].removeProduct();
                    if (resultado == 0)
                    {
                        listaVentas.RemoveAt(i);
                        inicializaTabla();
                    }
                    else
                    {
                        inicializaTabla();
                        dgvVenta.Rows[i].Selected = true;
                    }
                }
            }
        }

        private void dgvVenta_DoubleClick(object sender, EventArgs e)
        {
            if (dgvVenta.CurrentRow.Index != -1)
            {
                txtDescripcion.Text = dgvVenta.CurrentRow.Cells[1].Value.ToString();
                txtCategoria.Text = dgvVenta.CurrentRow.Cells[2].Value.ToString();
                txtProveedor.Text = dgvVenta.CurrentRow.Cells[3].Value.ToString();
                txtPrecio.Text = Convert.ToString(Convert.ToInt32(dgvVenta.CurrentRow.Cells[5].Value.ToString()) /
                    Convert.ToInt32(dgvVenta.CurrentRow.Cells[4].Value.ToString()));
            }
        }

        // Funcionar al Cobrar la VENTA
        private void btnNuevo_Click(object sender, EventArgs e)
        {       
            if (checkBoxPorPagar.Checked)
            {
                if (txtCliente.Text.Trim() == "")
                {
                    lblMsgClient.Visible = true;
                    lblMsgClient.Text = "Tiene que ingresar un cliente";
                    txtCliente.Focus();
                }
                else
                {
                    bool valido = ValidaRut(txtCliente.Text);
                    if (valido)
                    {
                        Console.WriteLine("Rut valido, Se puede continuar");
                        using (MySqlConnection mysqlcon = new MySqlConnection(connectionString))
                        {
                            mysqlcon.Open();
                            MySqlCommand mysqlcmd = new MySqlCommand("getClientByRut", mysqlcon);
                            mysqlcmd.CommandType = CommandType.StoredProcedure;
                            mysqlcmd.Parameters.AddWithValue("_rut", txtCliente.Text);
                            MySqlDataReader result = mysqlcmd.ExecuteReader();
                            if (result.Read())
                            {
                                lblMsgClient.Text = "";
                                Console.WriteLine("ALMACENA LA VENTA AL CLIENT: " + result[0].ToString());
                                makeSale();
                                storeDebt();
                                addClientSale(result[0].ToString());
                                clear();
                            }
                            else
                            {
                                lblMsgClient.Text = "No Existe el Cliente";
                                DialogResult newClient = MessageBox.Show("No existe el cliente, ¿Desea Agregarlo?", "Agregar Nuevo Cliente",
                                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                if (newClient.Equals(DialogResult.OK))
                                {
                                    Form_AddClient form_AddClient = new Form_AddClient(txtCliente.Text);
                                    form_AddClient.ShowDialog();
                                    //Console.WriteLine("SE CERRO");
                                    makeSale();
                                    storeDebt();
                                    addClientSale(txtCliente.Text);
                                    clear();
                                }
                                else
                                {
                                    DialogResult response = MessageBox.Show("Si no agrega el usuario, la venta se realizará como ANONIMA y PAGADA, ¿Desea Continuar?",
                                        "Agregar Nuevo Cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                    if (response.Equals(DialogResult.OK))
                                    {
                                        makeSale();
                                        Console.WriteLine("Realiza la venta (pagado)");
                                        clear();
                                    }
                                    else
                                    {
                                        MessageBox.Show("No se realizó la venta");
                                    }
                                }
                            }
                            mysqlcon.Close();
                        }
                    }
                    else
                    {
                        lblMsgClient.Text = "Rut Invalido";
                    }
                }
            }
            else
            {
                makeSale();
                Console.WriteLine("Realiza la venta (pagado)");
                clear();
            }
        }

        private void storeDebt()
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connectionString))
            {
                mysqlcon.Open();
                MySqlCommand mysqlcmd = new MySqlCommand("setNewDebt", mysqlcon);
                mysqlcmd.CommandType = CommandType.StoredProcedure;
                mysqlcmd.Parameters.AddWithValue("_rut_cliente", txtCliente.Text.Trim());
                mysqlcmd.Parameters.AddWithValue("_monto", lbTotal.Text);
                Console.WriteLine(lbTotal.Text);
                mysqlcmd.ExecuteNonQuery();
                mysqlcon.Close();
            }
        }

        //Valida rut Chileno
        public static bool ValidaRut(string rut)
        {
            rut = rut.Replace(".", "").ToUpper();
            Regex expresion = new Regex("^([0-9]+-[0-9K])$");
            string dv = rut.Substring(rut.Length - 1, 1);
            if (!expresion.IsMatch(rut))
            {
                return false;
            }
            char[] charCorte = { '-' };
            string[] rutTemp = rut.Split(charCorte);
            if (dv != Digito(int.Parse(rutTemp[0])))
            {
                return false;
            }
            return true;
        }

        //Metodo que valida el digito verificar, de acuerdo a la mantiza del rut
        //Es utilizado en el metodo para verificar Rut
        public static string Digito(int rut)
        {
            int suma = 0;
            int multiplicador = 1;
            while (rut != 0)
            {
                multiplicador++;
                if (multiplicador == 8)
                    multiplicador = 2;
                suma += (rut % 10) * multiplicador;
                rut = rut / 10;
            }
            suma = 11 - (suma % 11);
            if (suma == 11)
            {
                return "0";
            }
            else if (suma == 10)
            {
                return "K";
            }
            else
            {
                return suma.ToString();
            }
        }

        private void makeSale()
        {
            if (dgvVenta.Rows.Count != 0)
            {
                string totalVenta = lbTotal.Text;
                Form_Importe form_Importe = new Form_Importe(totalVenta);
                form_Importe.Show();

                //string fechaAct = txtFecha.Text.Substring(6, 4) + txtFecha.Text.Substring(3, 2) + txtFecha.Text.Substring(0, 2);
                string fechaAct = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");

                using (MySqlConnection mysqlcon = new MySqlConnection(connectionString))
                {
                    mysqlcon.Open();
                    MySqlCommand mysqlcmd = new MySqlCommand("insertVenta", mysqlcon);
                    mysqlcmd.CommandType = CommandType.StoredProcedure;
                    //mysqlcmd.Parameters.AddWithValue("_id", txtCodVenta.Text);
                    mysqlcmd.Parameters.AddWithValue("_fecha", fechaAct);
                    mysqlcmd.Parameters.AddWithValue("_rut_empleado", rut);
                    mysqlcmd.ExecuteNonQuery();
                    mysqlcon.Close();

                    int _id_venta = 0;

                    mysqlcon.Open();
                    MySqlCommand mysqlcmd5 = new MySqlCommand("getMaxIdVentas", mysqlcon);
                    mysqlcmd5.CommandType = CommandType.StoredProcedure;
                    MySqlDataReader result5 = mysqlcmd5.ExecuteReader();
                    if (result5.Read())
                    {
                        if (result5.IsDBNull(0))
                        {
                            MessageBox.Show("No existe registro en la BD");
                        }
                        else
                        {
                            Console.WriteLine(result5.GetInt32(0));

                            _id_venta = result5.GetInt32(0);
                            Console.WriteLine(_id_venta);

                            mysqlcon.Close();

                            for (int i = 0; i < listaVentas.Count; i++)
                            {
                                mysqlcon.Open();
                                MySqlCommand mysqlcmd2 = new MySqlCommand("insertVentaProducto", mysqlcon);
                                mysqlcmd2.CommandType = CommandType.StoredProcedure;
                                mysqlcmd2.Parameters.AddWithValue("_id_venta", _id_venta);
                                mysqlcmd2.Parameters.AddWithValue("_codigo_producto", listaVentas[i].Codigo);
                                mysqlcmd2.Parameters.AddWithValue("_cantidad", listaVentas[i].Cantidad);
                                mysqlcmd2.ExecuteNonQuery();
                                mysqlcon.Close();

                                mysqlcon.Open();
                                MySqlCommand mysqlcmd3 = new MySqlCommand("addGanancia", mysqlcon);
                                mysqlcmd3.CommandType = CommandType.StoredProcedure;
                                mysqlcmd3.Parameters.AddWithValue("_codigo", Convert.ToInt32(listaVentas[i].Codigo));
                                mysqlcmd3.Parameters.AddWithValue("_id_venta", _id_venta);
                                mysqlcmd3.Parameters.AddWithValue("_proveedor", txtProveedor.Text);
                                mysqlcmd3.Parameters.AddWithValue("_precio", Convert.ToInt32(listaVentas[i].Cantidad * listaVentas[i].Precio));
                                mysqlcmd3.Parameters.AddWithValue("_fecha", fechaAct);
                                mysqlcmd3.ExecuteNonQuery();
                                mysqlcon.Close();

                                mysqlcon.Open();
                                MySqlCommand mysqlcmd4 = new MySqlCommand("deductCantidad", mysqlcon);
                                mysqlcmd4.CommandType = CommandType.StoredProcedure;
                                mysqlcmd4.Parameters.AddWithValue("_codigo", listaVentas[i].Codigo);
                                mysqlcmd4.Parameters.AddWithValue("_cantidadReducir", listaVentas[i].Cantidad);
                                mysqlcmd4.ExecuteNonQuery();
                                mysqlcon.Close();
                            }
                            mysqlcon.Close();

                        }
                    }
                    else
                    {
                        MessageBox.Show("Error en la consulta a la BD");
                    }
                }
            }
            else
            {
                MessageBox.Show("Agregue algun producto para poder realizar la venta");
            }
        }

        private void addClientSale(string rut)
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
        }

        private void clear()
        {
            listaVentas.Clear();
            txtCliente.Text = "";
            txtCantidad.Text = "1";
            txtCategoria.Text = "";
            txtDescripcion.Text = "";
            txtIngresoProducto.Text = "Buscar Producto";
            txtIngresoProducto.ForeColor = Color.DimGray;
            txtPrecio.Text = "";
            txtProveedor.Text = "";
            lbMensaje.Text = "";
            lblMsgClient.Text = "";
            inicializaTabla();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            listaVentas.RemoveAt(dgvVenta.CurrentRow.Index);
            inicializaTabla();
        }

        private void checkBoxPorPagar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPorPagar.Checked)
            {
                lblMsgClient.Text = "";
                txtCliente.Enabled = true;
                txtCliente.BackColor = Color.White;
                txtCliente.Focus();
            }
            else
            {
                txtCliente.Enabled = false;
                lblMsgClient.Text = "";
                txtCliente.BackColor = Color.Gainsboro;
            }
        }

        private void txtCliente_Leave(object sender, EventArgs e)
        {
            
        }
    }

}
