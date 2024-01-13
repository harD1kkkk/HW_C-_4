using Myspace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zavd_4_c_
{
    internal class BookDecorator : Book
    {
        protected Book book;

        public BookDecorator(Book book) : base(book.Title, book.Author, book.Price)
        {
            this.book = book;
        }

        public override void Display()
        {
            base.Display();
        }
    }
}