using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Week6
{
    internal class Book
    {
        public string Title { get; set; }
        public double Price { get; set; }

        public override string ToString() => $"{Title} - Rs. {Price}";
    }
}
