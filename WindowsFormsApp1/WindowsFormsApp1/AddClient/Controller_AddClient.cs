using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.AddClient
{
    class Controller_AddClient
    {
        static private MySqlConnection mysqlcon = Connection.initConnection();

        public static string[] getClientByRut(string rut)
        {
            string[] data = new string[7];

            mysqlcon.Open();
            MySqlCommand mysqlcmd = new MySqlCommand("getClientByRut", mysqlcon);
            mysqlcmd.CommandType = CommandType.StoredProcedure;
            mysqlcmd.Parameters.AddWithValue("_rut", rut);
            MySqlDataReader result = mysqlcmd.ExecuteReader();
            if (result.Read())
            {
                data[0] = result[1].ToString();
                data[1] = result[2].ToString();
                data[2] = result[3].ToString();
                data[3] = result[4].ToString();
                data[4] = result[5].ToString();
                data[5] = result[6].ToString();
                data[6] = result[7].ToString();
                mysqlcon.Close();
                return data;
            }
            mysqlcon.Close();
            return data;
        }

        public static void addOrEditClient(string rut, string nombre, string fecha_nac, string sexo, string telefono, string direccion, string email, string observaciones)
        {
            if(telefono.Trim() == "")
            {
                telefono = "0";
            }
            mysqlcon.Open();
            MySqlCommand mysqlcmd = new MySqlCommand("AddOrEditClient", mysqlcon);
            mysqlcmd.CommandType = CommandType.StoredProcedure;
            mysqlcmd.Parameters.AddWithValue("_rut", rut);
            mysqlcmd.Parameters.AddWithValue("_nombre", nombre);
            mysqlcmd.Parameters.AddWithValue("_fecha_nac", fecha_nac);
            mysqlcmd.Parameters.AddWithValue("_sexo", sexo);
            mysqlcmd.Parameters.AddWithValue("_telefono", Convert.ToInt32(telefono));
            mysqlcmd.Parameters.AddWithValue("_direccion", direccion);
            mysqlcmd.Parameters.AddWithValue("_email", email);
            mysqlcmd.Parameters.AddWithValue("_observaciones", observaciones);
            mysqlcmd.ExecuteNonQuery();
            mysqlcon.Close();
        }
    }
}
