using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SmallRPG
{
    class Mies : Enemy
    {
        private int ChargeAttack;
        private Item CurrentItem;

        public Mies(string name, int health, ConsoleColor color, int chargeAttack)
            : base(name, health, color, Arts.Mies)
        {
            ChargeAttack = chargeAttack;
        }

        public void PickUpItem(Item item)
        {
            CurrentItem = item;
        }


        public void Charge()
        {
            BackgroundColor = Color;
            Write($" {Name} ");
            ResetColor();
            WriteLine($"  hyökkää päälle ja lyö kovaa vasemmalla koukulla {ChargeAttack} kertaa!");

            if (CurrentItem != null)
            {
                WriteLine($"Hänellä on {CurrentItem.Name}!");
            }
        }

        public void Hit()
        {
            BackgroundColor = Color;
            Write($" {Name} ");
            ResetColor();
            WriteLine($"  lyö oikealla koukulla!");
        }
    }
}
