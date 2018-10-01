using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace WindowsFormsApp1.Main
{
    class Controller_Main
    {
        static private MySqlConnection mysqlcon = Connection.initConnection();
        public static string[] getUserByRut(string rut)
        {
            string[] data = new string[2];
            mysqlcon.Open();
            MySqlCommand mysqlcmd = new MySqlCommand("getUserByRut", mysqlcon);
            mysqlcmd.Parameters.AddWithValue("_rut", rut);
            mysqlcmd.CommandType = CommandType.StoredProcedure;
            MySqlDataReader result = mysqlcmd.ExecuteReader();
            if (result.Read())
            {
                data[0] = result.GetString(1).ToString();
                data[1] = result.GetString(0).ToString();
                mysqlcon.Close();
                return data;
            }
            mysqlcon.Close();
            return data;
        }
    }
}
