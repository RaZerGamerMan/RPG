using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SmallRPG
{
    class Mies : Character
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

        public override void Fight(Character otherCharacter)
        {
            //WriteLine($"Mies {Name} lyö {otherCharacter.Name}a");
            // -50% ajasta Charge
            // -50% ajasta Charge menee ohi
            ForegroundColor = Color;
            ResetColor();
            int randPercent = RandGenerator.Next(1, 101);
            Write($"Isäntä {Name} hyökkää {otherCharacter.Name}on ja ");
            if (randPercent <= 50)
            {
                WriteLine("osuu 4 osumaa!");
                otherCharacter.TakeDamage(4);
            }
            else
            {
                WriteLine("ohi menee...");
            }
            ResetColor();
        }
    }
}
