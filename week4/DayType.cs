using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Week_4
{
    public enum DayType
    {
        Weekday,
        Weekend
    }
    public record Book(string title, string author, double price);

}