using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Tumakov
{
    class BookContainer
    {
        private Book[] books;
        public BookContainer(Book[] books)
        {
            this.books = books;
        }
        public void SortBooks(Comparison<Book> comparison)
        {
            Array.Sort(books, comparison);
        }
    }
}
