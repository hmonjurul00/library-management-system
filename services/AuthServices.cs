using System;
using db;
using models;

namespace services 
{
    public class Auth 
    {
        private MySQLConnector mySQLConnector = new MySQLConnector(); 
        public Auth() { }

        public Boolean userLogin(Login login) 
        {
            return mySQLConnector.userLogin(login);
        }
    }
}