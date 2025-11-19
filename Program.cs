using ConsoleApp.Week_4;
using System;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            Student One = new Student();
            One.Name = "Ganesh Neupane";
            One.Age = 57;
            One.Address = "Biratnagar, Morang";

            Student Two = new Student();
            Two.Name = "Himal Neupane";
            One.Age = 21;
            Two.Address = "Bargachi, Birtatnagar";

            Console.WriteLine("Student One Info:");
            Console.WriteLine($"Name: {One.Name}, Age: {One.Age}, Address: {One.Address}, Father Name: {Student.FatherName}");

            Console.WriteLine("Student Two Info:");
            Console.WriteLine($"Name: {Two.Name}, Age: {Two.Age}, Address: {Two.Address}, Father Name: {Student.FatherName}");

            static void RunCalculator()
            {
                Calculator calc = new Calculator();

                calc.PrintWelcome();

                int sum = calc.Add(10, 30);
                Console.WriteLine($"Add: {sum} ");

                int multiply = calc.Multiply(30, 40);
                Console.WriteLine($"Multiply: {multiply}");
            }

            Console.WriteLine();
            RunCalculator();

            Console.WriteLine();
            static void RunParameterDemo()
            {
                ParameterDemo demo = new ParameterDemo();

                int value = 5;
                Console.WriteLine($"Original value: {value}");
                demo.Increase(ref value);
                Console.WriteLine($"After Increase(ref): {value}");

                demo.GetFullName(out string fullName);
                Console.WriteLine($"Full name from out parameter: {fullName}");

                int total1 = demo.SumAll(4, 10, 18, 19, 5);
                int total2 = demo.SumAll(10, 20);
                Console.WriteLine($"SumAll(1,2,3,4,5) = {total1}");
                Console.WriteLine($"SumAll(10,20) = {total2}");
            }
            RunParameterDemo();

            Console.WriteLine();

            static void RunPlayer()
            {
                Player p1 = new Player();
                Console.WriteLine($"Player 1: Name: {p1.PlayerName}, Level: {p1.Level}, Health: {p1.Health}");

                Player p2 = new Player("Ram", 10, 180);
                Console.WriteLine($"Player 2: Name: {p2.PlayerName}, Level: {p2.Level}, Health: {p2.Health}");
            }
            RunPlayer();

            Console.WriteLine();

            static void RunEnumRecord()
            {
                Console.Write("Enter a day of the week: ");
                string dayInput = Console.ReadLine();

                DayType dayType;

                if (dayInput.Equals("Friday", StringComparison.OrdinalIgnoreCase) ||
                    dayInput.Equals("Saturday", StringComparison.OrdinalIgnoreCase))
                {
                    dayType = DayType.Weekend;
                }
                else
                {
                    dayType = DayType.Weekday;
                }

                Console.WriteLine($"It is: {dayType}");

                Book book1 = new Book("Ijoriya", "Subin Bhattarai", 999.0);

                Book book2 = book1 with { title = "Science", price = 1099.0 };

                Console.WriteLine("\nFirst book object:");
                Console.WriteLine(book1);

                var (title, author, price) = book2;
                Console.WriteLine("\nDeconstructed second book:");
                Console.WriteLine($"Title: {title}");
                Console.WriteLine($"Author: {author}");
                Console.WriteLine($"Price: {price}");
            }
            RunEnumRecord();

            Console.WriteLine();

            static void RunDebugging()
            {
                Console.WriteLine("Enter the marks obtained: ");
                string markInput = Console.ReadLine();

                Console.WriteLine("Enter the total marks: ");
                string totalMarks = Console.ReadLine();

                if (!int.TryParse(markInput, out int marks))
                {
                    Console.WriteLine("The input is invalid for marks.");
                    return;
                }

                if (!int.TryParse(totalMarks, out int total))
                {
                    Console.WriteLine("The input is invalid for total marks");
                    return;
                }

                if (total == 0)
                {
                    Console.WriteLine("The total marks can't be zero");
                    return;
                }

                // WRONG (for discussion): double percentage = marks / total * 100;
                // Reason: marks/total is a integer division. 

                double percentage = (double)marks / total * 100.0;
                Console.WriteLine($"Percentage = {percentage}%");

            }
            RunDebugging();

            /* 
             
           RESEARCH ON HOW CONSTRUCTOR HELP IN SOFTWARE DEVELOPEMENT: 
           Constructors are very important in object oriented programming because they help us to create object in proper initial state. 
           When we create object, sometimes we must give some required values, like id, name, or connection string, and constructor forces user to pass these values so object is not half‑initialized. 
           Constructors also reduce repeating code, because all common initialization logic is written in one place inside the class.*/

            /*
             
            REASEARCH ON ONE OF THE OOP PRINCIPLES: 
            One important concept of object oriented programming is encapsulation. Encapsulation means we hide internal data of the class and only expose necessary methods or properties to the outside world. 
            This helps to protect data from invalid changes and makes code easier to maintain, because other parts of program use only public interface, not internal implementation.

             A class is like a blueprint or design of an object, it defines which fields, properties, and methods an object will have. 
             An object is one actual instance created from this class during program execution, with its own values in fields and properties. In simple words, class is plan, object is real thing created from that plan.
             */
            Console.ReadLine();
        }


    }
}