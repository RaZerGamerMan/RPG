using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SmallRPG
{
    class Mies
    {
        private string Name;
        private int Health;
        private string TextArt;
        private ConsoleColor Color;
        private int ChargeAttack;

        public Mies(string name, int health, ConsoleColor color, int chargeAttack)
        {
            Name = name;
            Health = health;
            Color = color;
            ChargeAttack = chargeAttack;
            TextArt = Arts.Mies;
        }

        public void DisplayInfo()
        {
            ForegroundColor = Color;
            WriteLine($"---------{Name}---------");
            WriteLine($"\n{TextArt}\n");
            WriteLine($"Elämäpisteet: {Health}");
            WriteLine("---");
            ResetColor();
        }

        public void Charge()
        {
            WriteLine($"{Name} hyökkää päälle ja lyö kovaa vasemmalla koukulla {ChargeAttack} kertaa!");
        }

        public void Hit()
        {
            WriteLine($"{Name} lyö oikealla koukulla!");
        }
    }
}
