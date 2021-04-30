using System;

namespace models
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

        private Boolean availableBook = false;

        public Boolean AvailableBook
        {
            get { return availableBook; }
            set { availableBook = value; }
        }
        public ManagerBookEntry() { }

        public ManagerBookEntry(
            int _bookId,
            string _bookName,
            int _bookPublishYear,
            string _writerName,
            int _quantityOfBook,
            string _categoryName,
            Boolean _availableBook)
        {
            this.bookId = _bookId;
            this.bookName = _bookName;
            this.bookPublishYear = _bookPublishYear;
            this.writerName = _writerName;
            this.quantityOfBook = _quantityOfBook;
            this.catagoryName = _categoryName;
            this.availableBook = _availableBook;
        }

        public Boolean isValidManagerBookEntry()
        {
            if (string.IsNullOrEmpty(this.bookName))
            {
                return false;
            }
            if (this.bookPublishYear == 0)
            {
                return false;
            }
            if (string.IsNullOrEmpty(this.writerName))
            {
                return false;
            }
            if (this.quantityOfBook == 0)
            {
                return false;
            }
            if (string.IsNullOrEmpty(this.catagoryName))
            {
                return false;
            }
            return true;
        }
    }
}