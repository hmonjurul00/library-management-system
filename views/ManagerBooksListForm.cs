using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using db;
using models;

namespace library_management_system.views
{
    public partial class ManagerBooksListForm : Form
    {
        public ManagerBooksListForm()
        {
            InitializeComponent();
            loadData();
        }

        private void ManagerBookSearchForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void loadData()
        {
            MySQLConnector mySQLConnector = new MySQLConnector();
            List<ManagerBookEntry> managerBookEntries = mySQLConnector.getAllBooks();

            foreach (ManagerBookEntry managerBookEntry in managerBookEntries)
            {
                string[] row = new string[] {
                    managerBookEntry.BookId.ToString(),
                    managerBookEntry.BookName,
                    managerBookEntry.BookPublishYear.ToString(),
                    managerBookEntry.WriterName,
                    managerBookEntry.QuantityOfBook.ToString(),
                    managerBookEntry.CatagoryName,
                    managerBookEntry.AvailableBook == true ? "Yes" : "No"
                };
                this.dataGridView1.Rows.Add(row);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManagerAddBookInfoForm managerAddBookForm = new ManagerAddBookInfoForm();
            managerAddBookForm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
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
    }
}
