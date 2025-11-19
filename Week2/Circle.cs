using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Circle
    {
        public const double PI = 3.14;

        public static double CalculateArea(double radius)
        {
            return PI * radius * radius;
        }
    }
}
