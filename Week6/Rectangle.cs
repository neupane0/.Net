using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Week6
{
    internal class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        // Expression-bodied property
        public double Area => Width * Height;

        // Expression-bodied method for perimeter
        public double GetPerimeter() => 2 * (Width + Height);

        // Expression-bodied ToString
        public override string ToString() => $"Rectangle: {Width}x{Height}, Area: {Area}, Perimeter: {GetPerimeter()}";
    }
}
