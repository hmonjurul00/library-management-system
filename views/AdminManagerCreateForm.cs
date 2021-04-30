using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using models;
using db;

namespace library_management_system.views
{
    public partial class AdminManagerCreateForm : Form
    {
        private Login login;

        public AdminManagerCreateForm()
        {
            this.login = new Login();
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            this.login.FullName = (sender as TextBox).Text;
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            this.login.Username = (sender as TextBox).Text;
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            this.login.Password = (sender as TextBox).Text;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.login.Role = "manager";
            if (this.login.isValid() == true)
            {
                MySQLConnector mySQLConnector = new MySQLConnector();
                if (mySQLConnector.isMangerExist(login) == true)
                {
                    MessageBox.Show("Username already exists!!");
                }
                else
                {
                    try
                    {
                        mySQLConnector.addNewManager(this.login);
                        MessageBox.Show("Manegar created successfully!!");

                        clearFields();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to add manager!! An error occured!!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid input!!");
            }
        }

        private void clearFields()
        {
            this.textBox1.Clear();
            this.textBox2.Clear();
            this.textBox3.Clear();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            const string message = "Are you sure that you would like to logout?";
            const string caption = "Logout";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AdminManagerCreateForm_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }
    }
}
