using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Week_4
{
    internal class ParameterDemo
    {
        public void Increase(ref int number)
        {
            number += 10;
        }

        public void GetFullName(out string fullName)
        {
            fullName = "Himal Neupane";
        }

        public int SumAll(params int[] numbers)
        {
            int sum = 0;
            foreach (int n in numbers)
            {
                sum += n;
            }
            return sum;
        }
    }
}