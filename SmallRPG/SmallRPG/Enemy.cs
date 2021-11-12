using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace SmallRPG
{
    class Enemy
    {
        protected string Name;
        protected int Health;
        protected string TextArt;
        protected ConsoleColor Color;

        public Enemy(string name, int health, ConsoleColor color, string textArt)
        {
            Name = name;
            Health = health;
            Color = color;
            TextArt = textArt;
        }

        public void DisplayInfo()
        {
            BackgroundColor = Color;
            WriteLine($"---{Name}---");
            ResetColor();

            ForegroundColor = Color;
            WriteLine($"\n{TextArt}\n");
            WriteLine($"Elämäpisteet: {Health}");
            WriteLine("---");
            ResetColor();
        }

    }
}
