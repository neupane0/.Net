using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Week6
{
    internal class Applicant
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString() => $"{Name} (Age: {Age})";
    }
}
