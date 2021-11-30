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
        private bool SmallKnifeAttack;

        public Mies3(string name, int health, ConsoleColor color, bool knifeAttack)
            : base(name, health, color, Arts.Mies3)
        {
            SmallKnifeAttack = knifeAttack;
        }

        public void Surprise()
        {
            BackgroundColor = Color;
            Write($" {Name} ");
            ResetColor();
            WriteLine(" tulee luoksesi ja läimäisee!");

        }

        public void SmallKnife()
        {
            BackgroundColor = Color;
            Write($" {Name} ");
            ResetColor();
            WriteLine(" ottaa esille pienen veitsen ja lyö");
            if (SmallKnifeAttack)
            {
                WriteLine(" sinua naamaan!");
            }
            else
            {
                WriteLine(" sinua vatsaan!");
            }


        }
    }
}
