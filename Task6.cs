using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Task6
    {
        public static void RunTask6()
        {
            List<string> favoritefruits = new List<string> { "Banana", "Pineapple", "Kiwi" };
            Console.WriteLine("Initial fruit list:");
            Printfruit(favoritefruits);

            favoritefruits.Add("Dragon Fruit");
            Console.WriteLine("\nList after adding new fruit:");
            Printfruit(favoritefruits);

            favoritefruits.Remove("Kiwi");
            Console.WriteLine("\nList after removing a fruit:");
            Printfruit(favoritefruits);

            Console.WriteLine();
            foreach (string fruit in favoritefruits)
            {
                Console.WriteLine($"- {fruit}");
            }

            Dictionary<int, string> fruitDictionary = new Dictionary<int, string>()

            {
                { 1, "Mango"},
                { 2, "Apple" },
                { 3, "Grapes" }
            };
            Console.WriteLine("\nFruit Dictionary:");
            PrintDictionary(fruitDictionary);

            fruitDictionary.Add(4, "Grape");
            Console.WriteLine("\nDictionary after adding a new entry:");
            PrintDictionary(fruitDictionary);

            Console.WriteLine();
            foreach (KeyValuePair<int, string> entry in fruitDictionary)
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }
        }

        private static void Printfruit(List<string> fruits)
        {
            if (fruits.Count == 0)
            {
                Console.WriteLine("The list is empty");
            }
            else
            {
                foreach (string fruit in fruits)
                {
                    Console.WriteLine(fruit);
                }
            }
        }

        private static void PrintDictionary(Dictionary<int, string> dict)
        {
            if (dict.Count == 0)
            {
                Console.WriteLine("The dictionary is empty");
            }
            else
            {
                foreach (KeyValuePair<int, string> entry in dict)
                {
                    Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
                }
            }
        }
    }
}
