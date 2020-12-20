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
        string descripcion, categoria, proveedor;
        int cantidad, precio, stock;
        long codigo;

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public string Categoria
        {
            get
            {
                return categoria;
            }

            set
            {
                categoria = value;
            }
        }

        public string Proveedor
        {
            get
            {
                return proveedor;
            }

            set
            {
                proveedor = value;
            }
        }

        public long Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public int Cantidad
        {
            get
            {
                return cantidad;
            }

            set
            {
                cantidad = value;
            }
        }


        public int Stock
        {
            get
            {
                return stock;
            }

            set
            {
                stock = value;
            }
        }

        public int Precio
        {
            get
            {
                return precio;
            }

            set
            {
                precio = value;
            }
        }

        public bool addProducte(int cantidad)
        {
            MySqlConnection mysqlcon = Connection.initConnection();
            mysqlcon.Open();
            MySqlCommand mysqlcmd = new MySqlCommand("getStock", mysqlcon);
            mysqlcmd.CommandType = System.Data.CommandType.StoredProcedure;
            mysqlcmd.Parameters.AddWithValue("_codigo", Codigo);
            MySqlDataReader result = mysqlcmd.ExecuteReader();
            if (result.Read())
            {
                int cantidadLlevar = cantidad + this.Cantidad;
                if (cantidadLlevar > Convert.ToInt32(result.GetString(0).ToString()))
                {
                    mysqlcon.Close();
                    return false;
                } else
                {
                    mysqlcon.Close();
                    this.Cantidad = this.Cantidad + cantidad;
                    return true;
                }
            } else
            {
                mysqlcon.Close();
                Console.WriteLine("No es posible realizar la consulta");
                return true;
            }

        }

        public int addProduct(int cantidad)
        {
            this.Cantidad = this.Cantidad + cantidad;
            return this.Cantidad;
        }

        public int removeProduct()
        {
            this.Cantidad = this.Cantidad - 1;
            return this.Cantidad;
        }
    }

}
