using System;

namespace models
{
    public class Login
    {
        private string fullname;

        private string username;

        private string password;

        private string role;

        public Login() { }

        public Login(string _fullname, string _username, string _password, string _role)
        {
            this.fullname = _fullname;
            this.username = _username;
            this.password = _password;
            this.role = _role;
        }

        public string FullName
        {
            get { return fullname; }
            set { fullname = value; }
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

        internal bool isValid()
        {
            if (string.IsNullOrEmpty(this.fullname))
            {
                return false;
            }
            if (string.IsNullOrEmpty(this.username))
            {
                return false;
            }
            if (string.IsNullOrEmpty(this.password))
            {
                return false;
            }
            if (string.IsNullOrEmpty(this.role) || (this.role != "manager" && this.role != "admin"))
            {
                return false;
            }
            return true;
        }
    }
}