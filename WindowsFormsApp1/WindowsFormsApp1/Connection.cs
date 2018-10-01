using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    class Connection
    {
        static string connectionString = 
            "server = 35.198.31.209; user = tpvllanq; database = tpvllanquihueDB; port = 3306; password = 18653129a; SslMode=none";

        public static MySqlConnection initConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
