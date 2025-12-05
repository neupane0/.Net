using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Week6
{
    internal class CashierSales
    {
        public string CashierName { get; set; }
        public double Sales { get; set; }

        public override string ToString() => $"{CashierName}: Rs. {Sales}";
    }
}
