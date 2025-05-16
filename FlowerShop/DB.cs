using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop
{
    class DB
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;
        static NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);

        public static void openConnection()
        {
            if (npgSqlConnection.State == System.Data.ConnectionState.Closed)
            {
                npgSqlConnection.Open();
            }
        }

        public static void closeConneclion()
        {
            if (npgSqlConnection.State == System.Data.ConnectionState.Open)
            {
                npgSqlConnection.Close();
            }
        }

        public static NpgsqlConnection GetConnection()
        {
            return npgSqlConnection;
        }
    }
}
