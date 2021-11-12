using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SmallRPG
{
    class Game
    {

        private Mies Jorma;
        private Mies Seppo;
        private Mies2 Raimo;

        public Game()
        {
            Jorma = new Mies("Jorma", 20, ConsoleColor.Blue, 2);
            Seppo = new Mies("Seppo", 50, ConsoleColor.DarkGreen, 4);
            Raimo = new Mies2("Raimo", 75, ConsoleColor.Yellow, true);
        }


        public void Run()
        {
            WriteLine("### PIENI RPG ###\n");

            Jorma.DisplayInfo();
            WriteLine();
            Jorma.Charge();
            Jorma.Hit();
            WriteLine();

            Seppo.DisplayInfo();
            WriteLine();
            Seppo.Charge();
            Seppo.Hit();
            WriteLine();

            Raimo.DisplayInfo();
            WriteLine();

            WaitForKey();
        }

        private void WaitForKey()
        {
            WriteLine("Paina jotain näppäintä jatkaaksesi...\n");
            ReadKey(true);
        }
    }
}
