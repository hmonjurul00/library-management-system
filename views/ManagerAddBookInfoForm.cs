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
    public partial class ManagerAddBookInfoForm : Form
    {
        private ManagerBookEntry managerBookEntry;

        public ManagerAddBookInfoForm()
        {
            this.managerBookEntry = new ManagerBookEntry();
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            this.managerBookEntry.BookName = (sender as TextBox).Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.managerBookEntry.BookPublishYear = Int32.Parse((sender as TextBox).Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Input numbers only");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            this.managerBookEntry.WriterName = (sender as TextBox).Text;
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
            try
            { 
                this.managerBookEntry.QuantityOfBook = Int32.Parse((sender as TextBox).Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Input numbers only");
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            this.managerBookEntry.CatagoryName = (sender as TextBox).Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.managerBookEntry.AvailableBook == false)
            {
                this.managerBookEntry.AvailableBook = true;
            }
            else
            {
                this.managerBookEntry.AvailableBook = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!this.managerBookEntry.isValidManagerBookEntry())
            {
                MessageBox.Show("Invalid input!! Try again.");
            }
            else
            {
                try
                {
                    MySQLConnector mySQLConnector = new MySQLConnector();
                    mySQLConnector.addNewBookEntry(this.managerBookEntry);
                    MessageBox.Show("New Book added");
                    ManagerBooksListForm managerBooksListForm = new ManagerBooksListForm();
                    managerBooksListForm.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can not add book. A error occured!");
                }
            }
        }
    }
}
