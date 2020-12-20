using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Abonar
{
    class Controller_Abonar
    {
        static private MySqlConnection mysqlcon = Connection.initConnection();

        public static void updateDebt(string rut, string text)
        {
            mysqlcon.Open();
            MySqlCommand mysqlcmd = new MySqlCommand("updateDebt", mysqlcon);
            mysqlcmd.CommandType = CommandType.StoredProcedure;
            mysqlcmd.Parameters.AddWithValue("_rut", rut);
            mysqlcmd.Parameters.AddWithValue("_deuda", text);
            mysqlcmd.ExecuteNonQuery();

            mysqlcon.Close();
        }
    }
}
