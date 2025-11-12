using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class NullOperation
    {
        public static void PerformNullChecks()
        {
            string username = null;
            string showUsername = username ?? "Username is not available";

            Console.WriteLine($"Username: {showUsername}");
        }

        public static void PerformNullCoalescing()
        {
            string? usernameAnother = null;
            usernameAnother ??= "Himal";

            Console.WriteLine($"Username: {usernameAnother}");
        }
    }
}