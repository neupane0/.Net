using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Exceptions
    {
        public static void InvalidNum()
        {
            try
            {
                Console.Write("ENter a number: ");
                int n = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Enter a vadlid number, \n{ex}");
            }
            finally
            {
                Console.WriteLine("Program Executed");
            }
        }

        public static void PasswordCheck()
        {
            Console.Write("Enter your password: ");
            string pass = Console.ReadLine() ?? "";
            try
            {
                if (pass.Length < 6)
                {
                    throw new ArgumentException("Passowrd must be more than 6");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}