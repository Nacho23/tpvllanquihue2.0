using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace WindowsFormsApp1.Home
{
    class Controller_Home
    {
        static private MySqlConnection mysqlcon = Connection.initConnection();
        public static string getNumProveedores()
        {
            string response = "0";
            mysqlcon.Open();
            MySqlCommand mysqlcmd = new MySqlCommand("getNumProveedores", mysqlcon);
            mysqlcmd.CommandType = CommandType.StoredProcedure;
            MySqlDataReader result = mysqlcmd.ExecuteReader();
            if (result.Read())
                if (!result.IsDBNull(0)) response = result.GetInt32(0).ToString();
            mysqlcon.Close();
            return response;
        }

        public static string getNumProductos()
        {
            string response = "0";
            mysqlcon.Open();
            MySqlCommand mysqlcmd = new MySqlCommand("getNumProductos", mysqlcon);
            mysqlcmd.CommandType = CommandType.StoredProcedure;
            MySqlDataReader result = mysqlcmd.ExecuteReader();
            if (result.Read())
                if (!result.IsDBNull(0)) response = result.GetInt32(0).ToString();
            mysqlcon.Close();
            return response;
        }

        public static string getNumVentas()
        {
            string response = "0";
            mysqlcon.Open();
            MySqlCommand mysqlcmd = new MySqlCommand("getNumVentas", mysqlcon);
            mysqlcmd.CommandType = CommandType.StoredProcedure;
            MySqlDataReader result = mysqlcmd.ExecuteReader();
            if (result.Read())
                if (!result.IsDBNull(0)) response = result.GetInt32(0).ToString();
            mysqlcon.Close();
            return response;
        }

        public static string getGananciaMes()
        {
            CultureInfo cl = new CultureInfo("es-CL");
            string response = "0";
            string mes = DateTime.Now.ToString("MM");
            mysqlcon.Open();
            MySqlCommand mysqlcmd = new MySqlCommand("getGananciaMes", mysqlcon);
            mysqlcmd.CommandType = CommandType.StoredProcedure;
            mysqlcmd.Parameters.AddWithValue("_solicitud", "ingreso");
            mysqlcmd.Parameters.AddWithValue("_mes", mes);
            mysqlcmd.Parameters.AddWithValue("_dia", "");
            mysqlcmd.Parameters.AddWithValue("_proveedor", "");
            MySqlDataReader result = mysqlcmd.ExecuteReader();
            if (result.Read())
                if (!result.IsDBNull(0)) response = result.GetInt32(0).ToString("C", cl);
            mysqlcon.Close();
            return response;
        }
        public static DataTable getLowStockTable()
        {
            mysqlcon.Open();
            MySqlDataAdapter sqlDa = new MySqlDataAdapter("getLowStock", mysqlcon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dataTable = new DataTable();
            sqlDa.Fill(dataTable);
            mysqlcon.Close();
            return dataTable;
        }
    }
}
