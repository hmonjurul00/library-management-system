using System;

namespace library_management_system
{
    public class Login
    {
        private string username;

        private string password;

        private string role;

        public Login() { }

        public Login(string _username, string _password, string _role)
        {
            this.username = _username;
            this.password = _password;
            this.role = _role;
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Role
        {
            get { return role; }
            set { role = value; }
        }
    }
}