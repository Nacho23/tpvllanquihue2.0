using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    class ProductoVenta
    {
        string connectionString = "server = 35.198.31.209; user = tpvllanq; database = tpvllanquihueDB; port = 3306; password = 18653129a; SslMode=none";

        string descripcion, categoria, proveedor;
        int codigo, cantidad, precio;

        public string Descripcion
        {
            get => descripcion;
            set => descripcion = value;
        }

        public string Categoria {
            get => categoria;
            set => categoria = value;
        }

        public string Proveedor {
            get => proveedor;
            set => proveedor = value;
        }

        public int Codigo
        {
            get => codigo;
            set => codigo = value;
        }

        public int Cantidad
        {
            get => cantidad;
            set => cantidad = value;
        }

        public int Precio
        {
            get => precio;
            set => precio = value;
        }

        public bool addProduct(int cantidad)
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connectionString))
            {
                mysqlcon.Open();
                MySqlCommand mysqlcmd = new MySqlCommand("getStock", mysqlcon);
                mysqlcmd.CommandType = System.Data.CommandType.StoredProcedure;
                mysqlcmd.Parameters.AddWithValue("_codigo", codigo);
                MySqlDataReader result = mysqlcmd.ExecuteReader();
                if (result.Read())
                {
                    int cantidadLlevar = cantidad + this.cantidad;
                    if (cantidadLlevar > Convert.ToInt32(result.GetString(0).ToString()))
                    {
                        return false;
                    } else
                    {
                        this.cantidad = this.cantidad + cantidad;
                        return true;
                    }
                } else
                {
                    Console.WriteLine("No es posible realizar la consulta");
                    return true;
                }
            }

        }

        public int removeProduct()
        {
            this.cantidad = this.cantidad - 1;
            return this.cantidad;
        }
    }

}
