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

        private Pelaaja CurrentPlayer;
        private Character CurrentEnemy;
        private List<Character> Enemies;
        

        public Game()
        {
            
            Mies jorma = new Mies("Jorma", 10, ConsoleColor.Blue, 2);

            Mies seppo = new Mies("Seppo", 20, ConsoleColor.DarkGreen, 4);
            Item polttopullo = new Item("Polttopullo", 2);
            seppo.PickUpItem(polttopullo);

            Mies2 raimo = new Mies2("Raimo", 30, ConsoleColor.Red, true);

            //Polymorfismia
            Enemies = new List<Character>() { jorma, seppo, raimo };
            

        }


        public void Run()
        {
            WriteLine("### PIENI RPG ###\n");

            CurrentPlayer = new Pelaaja("Tero", 25, ConsoleColor.DarkCyan);
            CurrentPlayer.DisplayInfo();

            //kaikki voi tapella keskenään
            //CurrentPlayer.Fight(Enemies[0]);
            //CurrentPlayer.Fight(Enemies[1]);
            //CurrentPlayer.Fight(Enemies[2]);
            //Enemies[0].Fight(CurrentPlayer);
            //Enemies[0].Fight(Enemies[1]);

            CurrentEnemy = Enemies[0];

            while (true)
            {
                Clear();
                CurrentPlayer.DisplayHealthBar();
                CurrentEnemy.DisplayHealthBar();
                WriteLine();

                CurrentPlayer.Fight(CurrentEnemy);


                WriteLine();
                WaitForKey();

                Clear();
                CurrentPlayer.DisplayHealthBar();
                CurrentEnemy.DisplayHealthBar();
                WriteLine();

                CurrentEnemy.Fight(CurrentPlayer);

                WaitForKey();
            }



            // loopataan
            // elämäpisteet, pelaaja voi valita, minkä hyökkäyksen haluaa valita
            // pelaaja voi hyökätä viholliseen ja näytä tulokset
            // näytetään uudestaan päivitetyt elämäpisteet
            // katsotaan kuoleeko pelaaja tai vihollinen
            // vihollinen voi hyökätä pelaajaan ja näytä tulokset
            WaitForKey();
        }

        private void WaitForKey()
        {
            WriteLine("Paina jotain näppäintä jatkaaksesi...\n");
            ReadKey(true);
        }
    }
}
