using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello My Name is Himal Neupanee");
            Console.WriteLine("I live in Biratnagar, Morang");
            Console.WriteLine("My phone number is 9862671357");
            Console.WriteLine("College: Itahari Internation College");

            Console.WriteLine();

            

            Console.WriteLine("\nPrinting Task 1");
            Task1.RunTask1();

            Console.WriteLine("\nPriting Task 2");

            //Circle.PI = 3.1456;

            Console.WriteLine($"\nValue of PI constant: {Circle.PI}");

            double radius = 3.0;

            Console.WriteLine($"\nThe area of the circle with radius of {radius} is : {Circle.CalculateArea(radius)}");

            Console.WriteLine("\nPrinting Task 3");

            Task3.RunTask3();

            Console.WriteLine("\nPrinting Task 4");
            Task4.RunTask4();

            Console.WriteLine("\nPrinting Task 5");
            Task5.RunTask5();

            Console.WriteLine("\nPrinting Task 6");
            Task6.RunTask6();

            Console.ReadLine();
        }

    }
}
