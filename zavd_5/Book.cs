using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myspace
{
    internal class Book
    {
        public string Title { get; set; }
        public Author Author { get; set; }
        public double Price { get; set; }

        public Book(string title, Author author, double price)
        {
            Title = title;
            Author = author;
            Price = price;
        }

        public virtual void Display()
        {
            Console.WriteLine($"Title: {Title}\nAuthor: {Author.Name}\nPrice: {Price:C}");
        }
    }
}
