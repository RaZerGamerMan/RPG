using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SmallRPG
{
    class Mies3 : Enemy
    {
        private bool KnifeAttack;

        public Mies3(string name, int health, ConsoleColor color, bool knifeAttack)
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
            WriteLine(" otaa taskustaan jotain outoa ja lyö ");
            if (KnifeAttack)
            {
                WriteLine(" puukolla jalkaasi!");
            }
            else
            {
                WriteLine(" puukolla käteesi!");
            }


        }
    }
}
