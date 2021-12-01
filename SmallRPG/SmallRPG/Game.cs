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

        private List<Enemy> Enemies;
        

        public Game()
        {
            
            Mies jorma = new Mies("Jorma", 20, ConsoleColor.Blue, 2);

            Mies seppo = new Mies("Seppo", 50, ConsoleColor.DarkGreen, 4);
            Item polttopullo = new Item("Polttopullo", 2);
            seppo.PickUpItem(polttopullo);

            Mies2 raimo = new Mies2("Raimo", 75, ConsoleColor.Red, true);

            //Polymorfismia
            Enemies = new List<Enemy>() { jorma, seppo, raimo };
            

        }


        public void Run()
        {
            WriteLine("### PIENI RPG ###\n");

            foreach (Enemy enemy in Enemies)
            {
                enemy.DisplayInfo();
                enemy.Fight();
                WriteLine();
                //WriteLine("\nInstance Info:");
                //WriteLine($" >What is this instance? {enemy.GetType()}");
                //WriteLine($" >Is this an object? {enemy is object}");
                //WriteLine($" >Is this an enemy? {enemy is Enemy}");
                //WriteLine($" >Is this an Mies? {enemy is Mies}");
                //WriteLine($" >Is this an Mies2? {enemy is Mies2}");

                //if (enemy is Mies)
                //{
                //Mies mies = enemy as Mies;
                //mies.Charge();
                //mies.Hit();
                //}
                //else if (enemy is Mies)
                //{
                //Mies2 mies2 = enemy as Mies2;
                //mies2.Knife();
                //mies2.Surprise();
                //}
                
            }
        
    
            WaitForKey();
        }

        private void WaitForKey()
        {
            WriteLine("Paina jotain näppäintä jatkaaksesi...\n");
            ReadKey(true);
        }
    }
}
