using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Task5
    {
        public static void RunTask5()
        {
            DateTime birhtdate = new DateTime(2005, 09, 29);
            Console.WriteLine($"My birth date is: {birhtdate}");

            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine($"Current date and time is: {currentDateTime}");

            TimeSpan ageCalculate = currentDateTime - birhtdate;

            Console.WriteLine($"My age is: {ageCalculate.TotalDays:N0} days");

            double ageInYears = ageCalculate.TotalDays / 365;
            Console.WriteLine($"My age is: {ageInYears:N0} years");

            DateTime birthDatewith10PlusDay = birhtdate.AddDays(10);
            Console.WriteLine($"My birth date after adding 10 days: {birthDatewith10PlusDay}");
        }
    }
}
