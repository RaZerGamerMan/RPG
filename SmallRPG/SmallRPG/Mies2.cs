using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SmallRPG
{
    class Mies2 : Enemy
    {
        private bool KnifeAttack;

        public Mies2(string name, int health, ConsoleColor color, bool knifeAttack)
            : base(name, health, color, Arts.Mies2)
        {
            KnifeAttack = knifeAttack;
        }

        public void Surprise()
        {
            BackgroundColor = Color;
            Write($" {Name} ");
            ResetColor();
            WriteLine(" yllättää sinut takaapäin!");

        }

        public void Knife()
        {
            BackgroundColor = Color;
            Write($" {Name} ");
            ResetColor();
            WriteLine(" ");
            if (KnifeAttack) WriteLine("");

        }
    }
}
