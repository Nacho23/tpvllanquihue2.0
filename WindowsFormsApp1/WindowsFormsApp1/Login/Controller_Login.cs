using MySql.Data.MySqlClient;
using System;
using System.Data;
using WindowsFormsApp1;

namespace WindowsFormsApp1.Login
{
    class Controller_Login
    {
        static private MySqlConnection mysqlcon = Connection.initConnection();

        public static bool loginUser(string rut, string contrasena)
        {
            mysqlcon.Open();

            MySqlCommand mysqlcmd = new MySqlCommand("login", mysqlcon);
            mysqlcmd.CommandType = CommandType.StoredProcedure;
            mysqlcmd.Parameters.AddWithValue("_rut", rut);
            mysqlcmd.Parameters.AddWithValue("_contrasena", contrasena);
            MySqlDataReader result = mysqlcmd.ExecuteReader();
            bool res = result.Read();
            mysqlcon.Close();

            if (res) return true;
            return false;
        }

        public static void registerSession(string rut)
        {
            string actualDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            
            mysqlcon.Open();
            MySqlCommand mysqlcmd = new MySqlCommand("registerIn", mysqlcon);
            mysqlcmd.Parameters.AddWithValue("_rut", rut);
            mysqlcmd.Parameters.AddWithValue("_fecha", actualDate);
            mysqlcmd.CommandType = CommandType.StoredProcedure;
            mysqlcmd.ExecuteNonQuery();
            mysqlcon.Close();
        }
    }
}
