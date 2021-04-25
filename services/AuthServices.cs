using System;
using db;
using model;

namespace services 
{
    public class Auth 
    {
        private MySQLConnector mySQLConnector = new MySQLConnector(); 

        public Boolean userLogin(Login login) 
        {
            return mySQLConnector.userLogin(login);
        }
    }
}