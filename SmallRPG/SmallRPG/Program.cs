using System;

namespace SmallRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Pieni RPG";

            Game myGame = new Game();
            myGame.Run();

        }
    }
}
