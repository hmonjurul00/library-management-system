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

        public ManagerBookEntry() { }
    }
}