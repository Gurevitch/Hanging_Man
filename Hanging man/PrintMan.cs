using System;
using System.Collections.Generic;
using System.Text;

namespace Hanging_man
{
    class PrintMan
    {
        public static void Print_Man(int numOfTry)
        {

            switch(numOfTry)
            {
                case 1:
                    {
                        Console.WriteLine("O");
                        return;
                    }
                case 2:
                    {
                        Console.WriteLine("O");
                        Console.WriteLine("|");
                        return;
                    }
                case 3:
                    {
                        Console.WriteLine(" O");
                        Console.WriteLine("/|");
                        return;
                    }
                case 4:
                    {
                        Console.WriteLine(" O");
                        Console.WriteLine(@"/|\");
                        return;
                    }
                case 5:
                    {
                        Console.WriteLine(" O");
                        Console.WriteLine(@"/|\");
                        Console.WriteLine(@" /");
                        return;
                    }
                case 6:
                    {
                        Console.WriteLine(" O");
                        Console.WriteLine(@"/|\");
                        Console.WriteLine(@" /\");
                        return;
                    }
                case 7:
                    {
                        Console.WriteLine(" |");
                        Console.WriteLine(" O");
                        Console.WriteLine(@"/|\");
                        Console.WriteLine(@" /\");
                        return;
                    }
                case 8:
                    {
                        Console.WriteLine(" --|");
                        Console.WriteLine("   O");
                        Console.WriteLine(@"  /|\");
                        Console.WriteLine(@"   /\");
                        return;
                    }
                case 9:
                    {
                        Console.WriteLine(" --|");
                        Console.WriteLine("|  O");
                        Console.WriteLine(@"  /|\");
                        Console.WriteLine(@"   /\");
                        return;
                    }
                case 10:
                    {
                        Console.WriteLine(" --|");
                        Console.WriteLine("|  O");
                        Console.WriteLine(@"| /|\");
                        Console.WriteLine(@"   /\");
                        return;
                    }
                case 11:
                    {
                        Console.WriteLine(" --|");
                        Console.WriteLine("|  O");
                        Console.WriteLine(@"| /|\");
                        Console.WriteLine(@"|  /\");
                        return;
                    }
                case 12:
                    {
                        Console.WriteLine(" --|");
                        Console.WriteLine("|  O");
                        Console.WriteLine(@"| /|\");
                        Console.WriteLine(@"|  /\");
                        Console.WriteLine("| ");
                        return;
                    }
            }

            return;
        }
    }
}
