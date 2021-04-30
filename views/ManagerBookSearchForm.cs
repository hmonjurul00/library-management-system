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
    public partial class ManagerBookSearchForm : Form
    {
        public ManagerBookSearchForm()
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
                    managerBookEntry.AvailableBook.ToString()
                };
                this.dataGridView1.Rows.Add(row);
            }
        }
    }
}
