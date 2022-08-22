using System;
using System.Collections.Generic;
using System.Text;

namespace Hanging_man
{
    class ChooseLevelWord
    {
        public static string ChooseLevel()
        {
            int level = 0;
            string word;
            Console.WriteLine("Welcome! to start choose the level to the game you want, \n 1 = easy 2 = medium and 3 = hard");
            word = Console.ReadLine();
            level = Int32.Parse(word);
            try
            {
                switch (level)
                {
                    case 1:
                        return "house";
                    case 2:
                        return "happiness";
                    case 3:
                        return "tottenham hotspurs";
                    default:
                        throw new ArgumentOutOfRangeException("Unknown value");
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                throw new ArgumentOutOfRangeException("Unknown value");
            }
        }
    }
}
