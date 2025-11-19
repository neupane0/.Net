using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Week_4
{
    internal class Player
    {
        public string PlayerName;
        public int Level;
        public int Health;

        public Player()
        {
            Console.WriteLine("Default Constructor has been called");
            PlayerName = "Himal Neupane";
            Level = 100;
            Health = 100;
        }

        public Player(string playerName, int level, int health)
        {
            PlayerName = playerName;
            Level = level;
            Health = health;
        }
    }
}