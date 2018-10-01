using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Client
{
    class Controller_Client
    {
        static private MySqlConnection mysqlcon = Connection.initConnection();

        public static DataTable getClientTable(string text)
        {
            mysqlcon.Open();
            MySqlDataAdapter sqlDa = new MySqlDataAdapter("getClientData", mysqlcon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("_id", text);
            DataTable dataTableClientes = new DataTable();
            sqlDa.Fill(dataTableClientes);
            return dataTableClientes;
        } 
    }
}
