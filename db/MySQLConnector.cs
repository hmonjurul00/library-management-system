using System;
using MySql.Data.MySqlClient;
using models;
using System.Collections.Generic;

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

        public bool isMangerExist(Login login)
        {
            if (userLogin(login) == true)
            {
                return true;
            }
            return false;
        }

        internal void addNewManager(Login login)
        {
            connectMySQLDatabase();
            string query = "INSERT INTO `login` (`username`, `password`, `role`, `full_name`) VALUES " 
                + "('" + login.Username + "', '" + login.Password + "', '" + login.Role + "', '" + login.FullName + "')";

            MySqlCommand mySqlCommand = new MySqlCommand(query, connection);
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            mySqlDataReader.Close();
            closeConnection();
        }

        public List<ManagerBookEntry> getAllBooks()
        {
            connectMySQLDatabase();
            List<ManagerBookEntry> bookList = new List<ManagerBookEntry>();
            string query = "select * from manager_book_entry";

            MySqlCommand mySqlCommand = new MySqlCommand(query, connection);
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            while(mySqlDataReader.Read())
            {
                ManagerBookEntry managerBookEntry = new ManagerBookEntry(
                    mySqlDataReader.GetInt32("book_id"),
                    mySqlDataReader.GetString("book_name"),
                    mySqlDataReader.GetInt32("book_publish_year"),
                    mySqlDataReader.GetString("writer_name"),
                    mySqlDataReader.GetInt32("quantity_of_book"),
                    mySqlDataReader.GetString("catagory_name"),
                    mySqlDataReader.GetBoolean("is_available")
                );
                bookList.Add(managerBookEntry);
            }

            mySqlDataReader.Close();
            closeConnection();
            return bookList;
        }

        internal void addNewBookEntry(ManagerBookEntry managerBookEntry)
        {
            connectMySQLDatabase();
            string query = "INSERT INTO manager_book_entry (book_id, book_name, "
                + "book_publish_year, writer_name, quantity_of_book, "
                + " is_available, catagory_name) VALUES (NULL, "
                + "'" + managerBookEntry.BookName + "', '" + managerBookEntry.BookPublishYear.ToString() + "', '"
                + managerBookEntry.WriterName + "', '" + managerBookEntry.QuantityOfBook.ToString() + "', '" 
                + (managerBookEntry.AvailableBook == true ? 1 : 0) + "', '" + managerBookEntry.CatagoryName + "')";

            MySqlCommand mySqlCommand = new MySqlCommand(query, connection);
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            mySqlDataReader.Close();
            closeConnection();
        }
    }
}
