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

        public Game()
        {
            Jorma = new Mies("Jorma", 20, ConsoleColor.Blue, 2);
            Seppo = new Mies("Seppo", 50, ConsoleColor.DarkGreen, 4);
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

            WaitForKey();
        }

        private void WaitForKey()
        {
            WriteLine("Paina jotain näppäintä jatkaaksesi...\n");
            ReadKey(true);
        }
    }
}
