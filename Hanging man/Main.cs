using System;
using System.Collections.Generic;
using System.Text;

namespace Hanging_man
{
    class Hanging_Man_Game
    {
        static void Main(string[] args)
        {
            try
            {
                Game game = new Game(new HangingMenPrinter());
                game.Start();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
