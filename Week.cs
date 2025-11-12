using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Week
    {
        public static void WeekDay()
        {
            Console.Write("Enter the day of the week: ");
            int n = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Console.WriteLine("This day is Sunday");
                    break;
                case 2:
                    Console.WriteLine("This day is Monday");
                    break;
                case 3:
                    Console.WriteLine("This day is Tuesday");
                    break;
                case 4:
                    Console.WriteLine("This day is Wednesday");
                    break;
                case 5:
                    Console.WriteLine("This day is Thursday");
                    break;
                case 6:
                    Console.WriteLine("This day is Friday");
                    break;
                case 7:
                    Console.WriteLine("This day is Saturday");
                    break;
                default:
                    Console.WriteLine("Enter a valid day");
                    break;
            }
        }
    }
}