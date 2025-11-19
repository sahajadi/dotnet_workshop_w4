// Task4.cs
using System;

namespace dotnet_workshop_w4
{
    internal class Task4
    {
        // Instance fields
        public string playerName;
        public int level;
        public int health;

        // Default constructor
        public Task4()
        {
            Console.WriteLine("Default constructor has been called");
        }

        // Parameterized constructor
        public Task4(string name, int lvl, int hp)
        {
            playerName = name;
            level = lvl;
            health = hp;
        }

        // Method to display player info
        public void DisplayInfo()
        {
            Console.WriteLine("Player Name: " + playerName);
            Console.WriteLine("Level: " + level);
            Console.WriteLine("Health: " + health);
            Console.WriteLine();
        }
    }
}
