using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Operators
    {
        public static void Add(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine($"The sum of {a} and {b} is {sum}");
        }

        public static void Subtract(int a, int b)
        {
            int difference = a - b;
            Console.WriteLine($"The difference between {a} and {b} is {difference}");
        }

        public static void Multiply(int a, int b)
        {
            int product = a * b;
            Console.WriteLine($"The product of {a} and {b} is {product}");
        }

        public static void Divide(int a, int b)
        {
            int quotient = a / b;
            Console.WriteLine($"The quotient of {a} divided by {b} is {quotient}");
        }

        public static void OddEvenFinder(int x)
        {
            string result = (x % 2 == 0) ? "Even Number" : "Odd Number";
            Console.WriteLine(result);
        }
    }
}