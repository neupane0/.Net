using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Week_4
{
    internal class Calculator
    {
        public void PrintWelcome()
        {
            Console.WriteLine("Welcome to the Calculator");
        }

        public int Add(int num1, int numm2)
        {
            return num1 + numm2;
        }

        public int Multiply(int num1, int num2 = 1)
        {
            return num1 * num2;
        }
    }
}