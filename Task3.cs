using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Task3
    {
        public static void RunTask3()
        {
            byte b = 44;

            short shovan = 165;

            int i = 6700;

            long l = 9825948059L;

            float f = 3.14f;

            double d = 3.1456789;

            decimal dec = 3.145678907979m;

            char c = 'A';

            bool isFunny = false;

            int originalInt = 42;
            string originalIntToString = originalInt.ToString();
            Console.WriteLine($"\nThe original value of integer was {originalInt} and after string conversion the value is {originalIntToString}");

            string originalString = "3.14";
            double originalStringToDouble = Convert.ToDouble(originalString);
            Console.WriteLine($"\nThe original value of string was {originalString} and after double conversion the value is {originalStringToDouble}");

            Console.WriteLine();
            Console.WriteLine($"Byte variable: {b} (Type: {b.GetType()})");
            Console.WriteLine($"Short variable: {shovan} (Type: {shovan.GetType()})");
            Console.WriteLine($"Integer variable: {i} (Type: {i.GetType()})");
            Console.WriteLine($"Long variable: {l} (Type: {l.GetType()})");
            Console.WriteLine($"Float variable: {f} (Type: {f.GetType()})");
            Console.WriteLine($"Double variable: {d} (Type: {d.GetType()})");
            Console.WriteLine($"Decimal variable: {dec} (Type: {dec.GetType()})");
            Console.WriteLine($"Character variable: {c} (Type: {c.GetType()})");
            Console.WriteLine($"Boolean variable: {isFunny} (Type: {isFunny.GetType()})");



        }
    }
}
