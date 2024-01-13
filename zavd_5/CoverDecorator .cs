using Myspace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zavd_4_c_
{
    internal class CoverDecorator : BookDecorator
    {
        public string Cover { get; set; }

        public CoverDecorator(Book book, string cover) : base(book)
        {
            Cover = cover;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Cover: {Cover}");
        }
    }
}
