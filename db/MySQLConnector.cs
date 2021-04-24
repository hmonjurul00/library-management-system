using System;
using MySql.Data.MySqlClient;

namespace library_management_system
{
    public class MySQLConnector
    {
        private static const string connectionString = "server=localhost;database=LibraryBookStore;uid=root;pwd=;";
        private static MySqlConnection connection = new MySqlConnection(connectionString);

        public bool connectMySQLDatabase() 
        {
            try 
            {
                connection.Open();
                Console.WriteLine("connected with database successfully");
            }
            catch (Exception ex) 
            {
                Console.WriteLine("database connection failed!!!");
            }
            return false;
        }
    }
}
