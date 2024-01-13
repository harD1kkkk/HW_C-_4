using Myspace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace zavd_4_c_
{
    internal class LibraryUser
    {
        public string Name { get; set; }

        public LibraryUser(string name)
        {
            Name = name;
        }

        public void BorrowBook(Book book)
        {
            Console.WriteLine($"{Name} borrowed the book: {book.Title}");
        }

        public void ReturnBook(Book book)
        {
            Console.WriteLine($"{Name} returned the book: {book.Title}");
        }
    }
}
