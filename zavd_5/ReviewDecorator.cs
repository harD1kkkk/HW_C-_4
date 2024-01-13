using Myspace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zavd_4_c_
{
    internal class ReviewDecorator : BookDecorator
    {
        public string Review { get; set; }

        public ReviewDecorator(Book book, string review) : base(book)
        {
            Review = review;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Review: {Review}");
        }
    }
}