using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Week6

{
    public delegate int Calculate(int a, int b);

    // Delegate for discount strategy
    public delegate double DiscountStrategy(double price);
    internal class DiscountCalculator
    {
        // Calculate methods
        public static int Add(int a, int b) => a + b;
        public static int Subtract(int a, int b) => a - b;

        // Discount methods
        public static double FestivalDiscount(double price) => price * 0.80; // 20% off
        public static double SeasonalDiscount(double price) => price * 0.90; // 10% off
        public static double NoDiscount(double price) => price;

        // Method that accepts delegate
        public static double CalculateFinalPrice(double originalPrice, DiscountStrategy strategy)
        {
            return strategy(originalPrice);
        }
    }
}
