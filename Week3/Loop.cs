using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Loops
    {
        public static void SumN()
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
                Console.WriteLine($"The sum is: {sum}");
            }
        }

        public static void WhileCheck()
        {
            int n = 0;
            while (n <= 20)
            {
                if (n % 4 == 0)
                {
                    n++;
                }

                if (n == 15)
                {
                    break;
                }
                Console.WriteLine(n);
                n++;
            }
        }

        public static void ForEach()
        {
            int[] arr = { 1, 3, 5, 7, 10 };
            int total = 0;

            foreach (int n in arr)
            {
                total += n;

                Console.WriteLine($"The total is: {total}");
            }

        }
    }
}