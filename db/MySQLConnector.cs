using System;
using MySql.Data.MySqlClient;
using models;

namespace db
{
    public class MySQLConnector
    {
        private static string connectionString = "server=localhost;database=LibraryBookStore;UID=root;password=";
        private static MySqlConnection connection = new MySqlConnection(connectionString);

        public MySqlConnection Connection
        {
            get { return connection; }
        }

        private void connectMySQLDatabase()
        {
            connection.Open();
            Console.WriteLine("connected with database successfully");
        }

        private void closeConnection()
        {
            connection.Close();
        }

        public Boolean userLogin(Login login)
        {
            connectMySQLDatabase();
            string query = "select * from login where username=@username and password=@password and role=@role";
            
            MySqlCommand mySqlCommand = new MySqlCommand(query, connection);
            
            mySqlCommand.Parameters.Add("@username", MySqlDbType.VarChar);
            mySqlCommand.Parameters.Add("@password", MySqlDbType.VarChar);
            mySqlCommand.Parameters.Add("@role", MySqlDbType.VarChar);

            mySqlCommand.Parameters[0].Value = login.Username;
            mySqlCommand.Parameters[1].Value = login.Password;
            mySqlCommand.Parameters[2].Value = login.Role;

            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            

            if (mySqlDataReader.Read()) 
            {
                mySqlDataReader.Close();
                closeConnection();
                return true;
            }
            mySqlDataReader.Close();
            closeConnection();
            return false;
        }
    }
}
