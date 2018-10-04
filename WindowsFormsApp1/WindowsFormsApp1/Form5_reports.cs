using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Globalization;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Reportes : Form
    {
        string connectionString = "server = 35.198.31.209; user = tpvllanq; database = tpvllanquihueDB; port = 3306; password = 18653129a; SslMode=none";
        string pathDocs = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"\\INFORMES\\";


        public Reportes()
        {
            InitializeComponent();
            Console.WriteLine(pathDocs);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {            
            if(cbPeriodo.Text == "Enero")
            {
                actualizaInformacion("01", "Enero");
            }
            else if(cbPeriodo.Text == "Febrero")
            {
                actualizaInformacion("02", "Febrero");
            }
            else if (cbPeriodo.Text == "Marzo")
            {
                actualizaInformacion("03", "Marzo");
            }
            else if (cbPeriodo.Text == "Abril")
            {
                actualizaInformacion("04", "Abril");
            }
            else if (cbPeriodo.Text == "Mayo")
            {
                actualizaInformacion("05", "Mayo");
            }
            else if (cbPeriodo.Text == "Junio")
            {
                actualizaInformacion("06", "Junio");
            }
            else if (cbPeriodo.Text == "Julio")
            {
                actualizaInformacion("07", "Julio");
            }
            else if (cbPeriodo.Text == "Agosto")
            {
                actualizaInformacion("08", "Agosto");
            }
            else if (cbPeriodo.Text == "Septiembre")
            {
                actualizaInformacion("09", "Septiembre");
            }
            else if (cbPeriodo.Text == "Octubre")
            {
                actualizaInformacion("10", "Octubre");
            }
            else if (cbPeriodo.Text == "Noviembre")
            {
                actualizaInformacion("11", "Noviembre");
            }
            else if (cbPeriodo.Text == "Diciembre")
            {
                actualizaInformacion("12", "Diciembre");
            }
            lbPeriodo.Text = cbPeriodo.SelectedText;
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            string mes_2 = DateTime.Now.ToString("MM");
            string mes_4 = DateTime.Now.ToString("MMMM");
            lbPeriodo.Text = mes_4;
            cbPeriodo.SelectedText = mes_4;
            actualizaInformacion(mes_2, mes_4);
            completaCB();
            cbDias.SelectedText = DateTime.Now.ToString("dd");
            cbMeses.SelectedText = DateTime.Now.ToString("MM");
            cbAnio.SelectedText = "2018";
        }

        private void completaCB()
        {
            for (int i = 1; i < 32; i++)
            {
                cbDias.Items.Add(i);
            }

            for (int i = 1; i < 10; i++)
            {
                cbMeses.Items.Add("0" + i);
            }

            for (int i = 10; i < 13; i++)
            {
                cbMeses.Items.Add(i);
            }
        }

        private void actualizaInformacion(string mes_2, string mes_4)
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connectionString))
            {
                mysqlcon.Open();
                MySqlCommand mysqlcmdI = new MySqlCommand("getGananciaMes", mysqlcon);
                mysqlcmdI.CommandType = CommandType.StoredProcedure;
                mysqlcmdI.Parameters.AddWithValue("_solicitud", "ingreso");
                mysqlcmdI.Parameters.AddWithValue("_mes", mes_2);
                mysqlcmdI.Parameters.AddWithValue("_dia", "");
                mysqlcmdI.Parameters.AddWithValue("_proveedor", "");
                MySqlDataReader resultI = mysqlcmdI.ExecuteReader();
                if (resultI.Read())
                {
                    if(resultI.IsDBNull(0))
                    {
                        lbTotalIngresos.Text = "$0";
                    }
                    else
                    {
                        CultureInfo cl = new CultureInfo("es-CL");
                        lbTotalIngresos.Text = resultI.GetInt32(0).ToString("C", cl);
                    }
                }
                mysqlcon.Close();

                mysqlcon.Open();
                MySqlCommand mysqlcmd2 = new MySqlCommand("getGananciaMes", mysqlcon);
                mysqlcmd2.CommandType = CommandType.StoredProcedure;
                mysqlcmd2.Parameters.AddWithValue("_solicitud", "");
                mysqlcmd2.Parameters.AddWithValue("_mes", mes_2);
                mysqlcmd2.Parameters.AddWithValue("_dia", "");
                mysqlcmd2.Parameters.AddWithValue("_proveedor", "");
                MySqlDataReader result2 = mysqlcmd2.ExecuteReader();
                if (result2.Read())
                {
                    if (result2.IsDBNull(0))
                    {
                        lbGanancia.Text = "$0";
                    }
                    else
                    {
                        CultureInfo cl = new CultureInfo("es-CL");
                        lbGanancia.Text = result2.GetInt32(0).ToString("C", cl);
                    }

                }
                mysqlcon.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            generaInformeDiasMes();
        }

        private void generaInformeDiasMes()
        {

            //ABRIR EL DOCUMENTO
            FileStream fs = new FileStream(pathDocs + cbDias.Text + "-" + cbMeses.Text + ".pdf", FileMode.Create, FileAccess.Write, FileShare.None);
            Document document = new Document();
            document.SetPageSize(iTextSharp.text.PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();

            #region CabeceraDocumento
            //CABECERA DEL DOCUMENTO
            BaseFont bfntHead = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fntHead = new iTextSharp.text.Font(bfntHead, 16, 1, BaseColor.GRAY);
            Paragraph prgHeading = new Paragraph();
            prgHeading.Alignment = Element.ALIGN_CENTER;
            prgHeading.Add(new Chunk("Reporte Ventas diarias"));
            document.Add(prgHeading);
            #endregion CabeceraDocumento

            #region AutorYFecha
            //CABECERA DEL DOCUMENTO
            BaseFont bfntAuthor = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fntAuthor = new iTextSharp.text.Font(bfntAuthor, 8, 2, BaseColor.GRAY);
            Paragraph prgAuthor = new Paragraph();
            prgAuthor.Alignment = Element.ALIGN_RIGHT;
            prgAuthor.Add(new Chunk("Fecha: " + cbDias.Text + " del " + cbMeses.Text));
            document.Add(prgAuthor);
            #endregion AutorYFecha

            document.Add(new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 1))));

            document.Add(new Chunk("\n"));

            #region ConexionBD
            //CONEXION Y BUSQUEDA DE DATOS UTILES
            using (MySqlConnection mysqlcon = new MySqlConnection(connectionString))
            {
                string[] proveedores;
                Cursor.Current = Cursors.WaitCursor;

                //OBTIENE TOTAL DE PROVEEDORES
                mysqlcon.Open();
                MySqlCommand mysqlcmd = new MySqlCommand("getNumProveedores", mysqlcon);
                mysqlcmd.CommandType = CommandType.StoredProcedure;
                MySqlDataReader result = mysqlcmd.ExecuteReader();
                if (result.Read())
                {
                    proveedores = new string[Convert.ToInt32(result.GetInt32(0).ToString())];
                    mysqlcon.Close();

                    //RETORNA UNA LISTA DE TODOS LOS PORVEEDORES
                    mysqlcon.Open();
                    MySqlCommand mysqlcmd1 = new MySqlCommand("ViewAllProveedor", mysqlcon);
                    mysqlcmd1.CommandType = CommandType.StoredProcedure;
                    MySqlDataReader result1 = mysqlcmd1.ExecuteReader();
                    if (result1.HasRows)
                    {
                        int i = 0;
                        while (result1.Read())
                        {
                            proveedores[i] = result1.GetString(1);
                            i++;
                        }
                    }
                    mysqlcon.Close();

                    //POR CADA PROVEEDOR OBTENEMOS INFO DEL SUS PRODUCTOS, TOTAL DE INGRESOS Y TOTAL DE GANANCIAS
                    string fecha = cbAnio.Text + "-" + cbMeses.Text + "-" + cbDias.Text;
                    for (int i = 0; i < proveedores.Length; i++)
                    {
                        string name = i.ToString();
                        string proveedor = proveedores[i];

                        mysqlcon.Open();
                        MySqlDataAdapter mysqlcmd2 = new MySqlDataAdapter("getVentasDiarias", mysqlcon);
                        mysqlcmd2.SelectCommand.CommandType = CommandType.StoredProcedure;
                        mysqlcmd2.SelectCommand.Parameters.AddWithValue("_proveedor", proveedores[i]);
                        mysqlcmd2.SelectCommand.Parameters.AddWithValue("_fecha", fecha);
                        DataTable dataTableResult = new DataTable();
                        mysqlcmd2.Fill(dataTableResult);

                        mysqlcon.Close();

                        string ingresoTotal = "";

                        mysqlcon.Open();
                        MySqlCommand mysqlcmd3 = new MySqlCommand("getGananciaMes", mysqlcon);
                        mysqlcmd3.CommandType = CommandType.StoredProcedure;
                        mysqlcmd3.Parameters.AddWithValue("_solicitud", "ingreso");
                        mysqlcmd3.Parameters.AddWithValue("_dia", cbDias.Text);
                        mysqlcmd3.Parameters.AddWithValue("_mes", "");
                        mysqlcmd3.Parameters.AddWithValue("_proveedor", proveedores[i]);
                        MySqlDataReader result3 = mysqlcmd3.ExecuteReader();
                        if (result3.Read())
                        {
                            if (result3.IsDBNull(0))
                            {
                                ingresoTotal = "$0";
                            }
                            else
                            {
                                CultureInfo cl = new CultureInfo("es-CL");
                                ingresoTotal = result3.GetInt32(0).ToString("C", cl);
                            }
                        }
                        mysqlcon.Close();

                        string gananciaTotal = "";

                        mysqlcon.Open();
                        MySqlCommand mysqlcmd4 = new MySqlCommand("getGananciaMes", mysqlcon);
                        mysqlcmd4.CommandType = CommandType.StoredProcedure;
                        mysqlcmd4.Parameters.AddWithValue("_solicitud", "");
                        mysqlcmd4.Parameters.AddWithValue("_dia", cbDias.Text);
                        mysqlcmd4.Parameters.AddWithValue("_mes", "");
                        mysqlcmd4.Parameters.AddWithValue("_proveedor", proveedores[i]);
                        MySqlDataReader result4 = mysqlcmd4.ExecuteReader();
                        if (result4.Read())
                        {
                            if (result4.IsDBNull(0))
                            {
                                gananciaTotal = "$0";
                            }
                            else
                            {
                                CultureInfo cl = new CultureInfo("es-CL");
                                gananciaTotal = result4.GetInt32(0).ToString("C", cl);
                            }
                        }
                        mysqlcon.Close();

                        //EXPORTAR AL DOCUMENTO POR CADA ITERACION
                        exportInfoToPDFDias(document, dataTableResult, proveedor, ingresoTotal, gananciaTotal);
                    }


                    //CERRAR DOCUMENTO
                    document.Close();
                    writer.Close();
                    fs.Close();
                }
            }
            Cursor.Current = Cursors.Default;
            lbMensaje.Visible = true;

            #endregion ConexionBD
        }

        public void exportInfoToPDFDias(Document document, DataTable dataTableResult, string proveedor, string ingresoTotal, string gananciaTotal)
        {

            //Tabla (SI NO RETORNA COLUMNAS VALIDAS, 
            if (dataTableResult.Columns.Count == 0)
            {
                PdfPTable table = new PdfPTable(1);

                table.AddCell("Error de conexión");

                document.Add(table);
            } else
            //RETORNA COLUMNAS VALIDAS
            {
                PdfPTable table = new PdfPTable(dataTableResult.Columns.Count);

                document.Add(new Paragraph("Proveedor: " + proveedor));
                document.Add(new Chunk("\n"));

                //COLUMNAS TABLA
                BaseFont btnColumnHeader = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                iTextSharp.text.Font fontColumnHeader = new iTextSharp.text.Font(btnColumnHeader, 10, 1, BaseColor.WHITE);
                for (int i = 0; i < dataTableResult.Columns.Count; i++)
                {
                    PdfPCell cell = new PdfPCell();
                    cell.BackgroundColor = BaseColor.GRAY;
                    cell.AddElement(new Chunk(dataTableResult.Columns[i].ColumnName.ToUpper(), fontColumnHeader));
                    table.AddCell(cell);
                }

                //FILAS TABLA
                for (int i = 0; i < dataTableResult.Rows.Count; i++)
                {
                    for (int j = 0; j < dataTableResult.Columns.Count; j++)
                    {
                        table.AddCell(dataTableResult.Rows[i][j].ToString());
                    }
                }

                document.Add(table);

                document.Add(new Chunk("\n"));

                //INGRESO Y GANANCIA TOTAL

                document.Add(new Paragraph("Ingreso Total: " + ingresoTotal));
                document.Add(new Paragraph("Ganancia Total: " + gananciaTotal));
                document.Add(new Paragraph(""));
                document.Add(new Paragraph(""));
                document.Add(new Chunk("\n"));
                document.Add(new Chunk("\n"));
            }
        }

        public void exportInfoToPDFMeses(Document document, DataTable dataTableResult)
        {

            //Tabla (SI NO RETORNA COLUMNAS VALIDAS, 
            if (dataTableResult.Columns.Count == 0)
            {
                PdfPTable table = new PdfPTable(1);

                table.AddCell("Error de conexión");

                document.Add(table);
            }
            else
            //RETORNA COLUMNAS VALIDAS
            {
                PdfPTable table = new PdfPTable(dataTableResult.Columns.Count);

                //COLUMNAS TABLA
                BaseFont btnColumnHeader = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                iTextSharp.text.Font fontColumnHeader = new iTextSharp.text.Font(btnColumnHeader, 10, 1, BaseColor.WHITE);
                for (int i = 0; i < dataTableResult.Columns.Count; i++)
                {
                    PdfPCell cell = new PdfPCell();
                    cell.BackgroundColor = BaseColor.GRAY;
                    cell.AddElement(new Chunk(dataTableResult.Columns[i].ColumnName.ToUpper(), fontColumnHeader));
                    table.AddCell(cell);
                }

                //FILAS TABLA
                for (int i = 0; i < dataTableResult.Rows.Count; i++)
                {
                    for (int j = 0; j < dataTableResult.Columns.Count; j++)
                    {
                        table.AddCell(dataTableResult.Rows[i][j].ToString());
                    }
                }

                document.Add(table);

                document.Add(new Chunk("\n"));
            }
        }

        private void btnInformeMensual_Click(object sender, EventArgs e)
        {
            //ABRIR EL DOCUMENTO
            FileStream fs = new FileStream(pathDocs + cbMeses.Text + ".pdf", FileMode.Create, FileAccess.Write, FileShare.None);
            Document document = new Document();
            document.SetPageSize(iTextSharp.text.PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();

            #region CabeceraDocumento
            //CABECERA DEL DOCUMENTO
            BaseFont bfntHead = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fntHead = new iTextSharp.text.Font(bfntHead, 16, 1, BaseColor.GRAY);
            Paragraph prgHeading = new Paragraph();
            prgHeading.Alignment = Element.ALIGN_CENTER;
            prgHeading.Add(new Chunk("Reporte Ventas Mensuales"));
            document.Add(prgHeading);
            #endregion CabeceraDocumento

            #region AutorYFecha
            //CABECERA DEL DOCUMENTO
            BaseFont bfntAuthor = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fntAuthor = new iTextSharp.text.Font(bfntAuthor, 8, 2, BaseColor.GRAY);
            Paragraph prgAuthor = new Paragraph();
            prgAuthor.Alignment = Element.ALIGN_RIGHT;
            prgAuthor.Add(new Chunk("Mes: "  + cbMeses.Text));
            document.Add(prgAuthor);
            #endregion AutorYFecha

            document.Add(new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 1))));

            document.Add(new Chunk("\n"));

            #region ConexionBD
            //CONEXION Y BUSQUEDA DE DATOS UTILES
            using (MySqlConnection mysqlcon = new MySqlConnection(connectionString))
            {
                string[] proveedores;
                Cursor.Current = Cursors.WaitCursor;

                //OBTIENE TOTAL DE PROVEEDORES
                mysqlcon.Open();
                MySqlCommand mysqlcmd = new MySqlCommand("getNumProveedores", mysqlcon);
                mysqlcmd.CommandType = CommandType.StoredProcedure;
                MySqlDataReader result = mysqlcmd.ExecuteReader();
                if (result.Read())
                {
                    proveedores = new string[Convert.ToInt32(result.GetInt32(0).ToString())];
                    mysqlcon.Close();

                    //RETORNA UNA LISTA DE TODOS LOS PORVEEDORES
                    mysqlcon.Open();
                    MySqlCommand mysqlcmd1 = new MySqlCommand("ViewAllProveedor", mysqlcon);
                    mysqlcmd1.CommandType = CommandType.StoredProcedure;
                    MySqlDataReader result1 = mysqlcmd1.ExecuteReader();
                    if (result1.HasRows)
                    {
                        int i = 0;
                        while (result1.Read())
                        {
                            proveedores[i] = result1.GetString(1);
                            i++;
                        }
                    }
                    mysqlcon.Close();

                    //POR CADA PROVEEDOR OBTENEMOS INFO DEL SUS PRODUCTOS, TOTAL DE INGRESOS Y TOTAL DE GANANCIAS
                    for (int i = 0; i < proveedores.Length; i++)
                    {
                        string name = i.ToString();

                        mysqlcon.Open();
                        MySqlDataAdapter mysqlcmd2 = new MySqlDataAdapter("getIngresoTotalYGananciaPorMes", mysqlcon);
                        mysqlcmd2.SelectCommand.CommandType = CommandType.StoredProcedure;
                        mysqlcmd2.SelectCommand.Parameters.AddWithValue("_proveedor", proveedores[i]);
                        mysqlcmd2.SelectCommand.Parameters.AddWithValue("_mes", cbMeses.Text);
                        DataTable dataTableResult = new DataTable();
                        mysqlcmd2.Fill(dataTableResult);

                        mysqlcon.Close();

                        //EXPORTAR AL DOCUMENTO POR CADA ITERACION
                        exportInfoToPDFMeses(document, dataTableResult);
                    }


                    //CERRAR DOCUMENTO
                    document.Close();
                    writer.Close();
                    fs.Close();
                }
            }
            Cursor.Current = Cursors.Default;
            lbMensaje.Visible = true;

            #endregion ConexionBD
        }

    }
}
