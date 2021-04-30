using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using models;
using services;

namespace library_management_system.views
{
    public partial class ManagerLoginForm : Form
    {
        private Login login;
        public ManagerLoginForm()
        {
            this.login = new Login("", "", "", "manager");
            InitializeComponent();
            this.textBox2.PasswordChar = '*';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.login.Username = (sender as TextBox).Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.login.Password = (sender as TextBox).Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Auth auth = new Auth();
            if (auth.userLogin(this.login) == true)
            {
                ManagerBooksListForm managerBooksListForm = new ManagerBooksListForm();
                managerBooksListForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect username or password!");
            }
        }
    }
}
