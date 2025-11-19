using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class IfElseSwitch
    {
        public static void Age()
        {
            Console.Write("Enter the age:");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 13)
            {
                Console.WriteLine("You are a child");
            }
            else if (age >= 13 && age <= 19)
            {
                Console.WriteLine("Your are a teenager");
            }
            else
            {
                Console.WriteLine("You are a adult");
            }
        }
    }
}