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

        public Game()
        {
            Jorma = new Mies("Jorma", 100, ConsoleColor.Blue, 2);
        }


        public void Run()
        {
            WriteLine("### PIENI RPG ###\n");

            Jorma.DisplayInfo();
            WriteLine();
            Jorma.Charge();
            Jorma.Hit();
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
