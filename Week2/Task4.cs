using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Task4
    {
        public static void RunTask4()
        {

            int[] favoriteNumber = { 1, 3 ,2, 5, 4 };
            Console.WriteLine("\nOriginal array: " + string.Join(",", favoriteNumber));

            Array.Sort(favoriteNumber);
            Console.WriteLine("\nSorted Array: " + string.Join(",", favoriteNumber));

            Array.Reverse(favoriteNumber);
            Console.WriteLine("\nReversed Array: " + string.Join(",", favoriteNumber));

            for (int i = 0; i < favoriteNumber.Length; i++)
            {
                Console.WriteLine($"\nElement at index {i}: {favoriteNumber[i]}");
            }

            int numberToFind = 3;
            int index = Array.IndexOf(favoriteNumber, numberToFind);

            if (index != -1)
            {
                Console.WriteLine($"\nNumber {numberToFind} found at index {index}.");
            }
            else             {
                Console.WriteLine($"\nNumber {numberToFind} not found in the array.");
            }
        }
    }
}
