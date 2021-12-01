using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace SmallRPG
{
    class Character
    {
        public string Name { get; protected set; }
        public int Health { get; protected set; }
        public string TextArt { get; protected set; }
        public ConsoleColor Color { get; protected set; }
        public Random RandGenerator { get; protected set; }

        public Character(string name, int health, ConsoleColor color, string textArt)
        {
            Name = name;
            Health = health;
            Color = color;
            TextArt = textArt;
            RandGenerator = new Random();
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
        public virtual void Fight(Character otherCharacter)
        {

            WriteLine("tapellaaaaan!");
        }

    }
}
