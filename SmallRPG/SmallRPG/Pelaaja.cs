using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SmallRPG
{
    class Pelaaja : Character
    {
        public Pelaaja(string name, int health, ConsoleColor color)
            : base(name, health, color, Arts.Pelaaja)
        {

        }
        public override void Fight(Character otherCharacter)
        {
            
            ForegroundColor = Color;
            WriteLine($"Pelaaja {Name} lyö {otherCharacter.Name}a.");
            ResetColor();
        }
    }
}