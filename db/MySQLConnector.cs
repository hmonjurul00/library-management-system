using System;
using MySql.Data.MySqlClient;

namespace db
{
    public class MySQLConnector
    {
        private static string connectionString = "server=localhost;database=LibraryBookStore;UID=root;password=";
        private static MySqlConnection connection = new MySqlConnection(connectionString);

        public void connectMySQLDatabase() 
        {
           connection.Open();
           Console.WriteLine("connected with database successfully");
        }
    }
}
