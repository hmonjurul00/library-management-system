using System;

namespace library_management_system
{
    public class ManagerBookEntry
    {
        private int bookId;

        public int BookId
        {
            get { return bookId; }
            set { bookId = value; }
        }

        private string bookName;

        public string BookName
        {
            get { return bookName; }
            set { bookName = value; }
        }

        private int bookPublishYear;

        public int BookPublishYear
        {
            get { return bookPublishYear; }
            set { bookPublishYear = value; }
        }

        private string writerName;

        public string WriterName
        {
            get { return writerName; }
            set { writerName = value; }
        }

        private int quantityOfBook;

        public int QuantityOfBook
        {
            get { return quantityOfBook; }
            set { quantityOfBook = value; }
        }

        private string catagoryName;

        public string CatagoryName
        {
            get { return catagoryName; }
            set { catagoryName = value; }
        }

        private DateTime entryDate;

        public DateTime EntryDate
        {
            get { return entryDate; }
            set { entryDate = value; }
        }

        private Boolean availableBook;

        public Boolean AvailableBook
        {
            get { return availableBook; }
            set { availableBook = value; }
        }
        public ManagerBookEntry() { }

        public ManagerBookEntry(int _bookId, string _bookName, int _bookPublishYear) { }
    }
}