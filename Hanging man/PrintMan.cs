using System;
using System.Collections.Generic;
using System.Text;

namespace Hanging_man
{
    public class HangingMenPrinter
    {
        public void PrintMan(int numOfTry)
        {
            switch(numOfTry)
            {
                case 1:
                    {
                        Console.WriteLine();
                        Console.WriteLine("you got more {0} errors left",12 -numOfTry );
                        Console.WriteLine("O");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine();
                        Console.WriteLine("you got more {0} errors left", 12 - numOfTry);
                        Console.WriteLine("O");
                        Console.WriteLine("|");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine();
                        Console.WriteLine("you got more {0} errors left", 12 - numOfTry);
                        Console.WriteLine(" O");
                        Console.WriteLine("/|");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine();
                        Console.WriteLine("you got more {0} errors left", 12 - numOfTry);
                        Console.WriteLine(" O");
                        Console.WriteLine(@"/|\");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine();
                        Console.WriteLine("you got more {0} errors left", 12 - numOfTry);
                        Console.WriteLine(" O");
                        Console.WriteLine(@"/|\");
                        Console.WriteLine(@" /");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine();
                        Console.WriteLine("you got more {0} errors left", 12 - numOfTry);
                        Console.WriteLine(" O");
                        Console.WriteLine(@"/|\");
                        Console.WriteLine(@" /\");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine();
                        Console.WriteLine("you got more {0} errors left", 12 - numOfTry);
                        Console.WriteLine(" |");
                        Console.WriteLine(" O");
                        Console.WriteLine(@"/|\");
                        Console.WriteLine(@" /\");
                        break;
                    }
                case 8:
                    {
                        Console.WriteLine();
                        Console.WriteLine("you got more {0} errors left", 12 - numOfTry);
                        Console.WriteLine(" --|");
                        Console.WriteLine("   O");
                        Console.WriteLine(@"  /|\");
                        Console.WriteLine(@"   /\");
                        break;
                    }
                case 9:
                    {
                        Console.WriteLine();
                        Console.WriteLine("you got more {0} errors left", 12 - numOfTry);
                        Console.WriteLine(" --|");
                        Console.WriteLine("|  O");
                        Console.WriteLine(@"  /|\");
                        Console.WriteLine(@"   /\");
                        break;
                    }
                case 10:
                    {
                        Console.WriteLine();
                        Console.WriteLine("you got more {0} errors left", 12 - numOfTry);
                        Console.WriteLine(" --|");
                        Console.WriteLine("|  O");
                        Console.WriteLine(@"| /|\");
                        Console.WriteLine(@"   /\");
                        break;
                    }
                case 11:
                    {
                        Console.WriteLine();
                        Console.WriteLine("you got more {0} errors left", 12 - numOfTry);
                        Console.WriteLine(" --|");
                        Console.WriteLine("|  O");
                        Console.WriteLine(@"| /|\");
                        Console.WriteLine(@"|  /\");
                        break;
                    }
                case 12:
                    {
                        Console.WriteLine();
                        Console.WriteLine("you got more {0} errors left", 12 - numOfTry);
                        Console.WriteLine(" --|");
                        Console.WriteLine("|  O");
                        Console.WriteLine(@"| /|\");
                        Console.WriteLine(@"|  /\");
                        Console.WriteLine("| ");
                        break;
                    }
            }
            return;
        }
    }
}
