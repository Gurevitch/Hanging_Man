using System;
using System.Collections.Generic;
using System.Text;

namespace Hanging_man
{
    class Hanging_Man_Game
    {

        static void Main(string[] args)
        {
            int Max_Num_Of_Tries = 12;
            int errors = 1;
            string Word = ChooseLevelWord.ChooseLevel();
            string GuessLetter = "a";
            var EmptyWord = new StringBuilder();
            int CorrectGuess = 0;
            int RemainLettersToFind = 0;
            int i = 0;
            bool FoundALetter = false;
            bool FirstTime = true;
            List<string> UsedLetter = new List<string>();
            while (errors < Max_Num_Of_Tries)
            {
                if (CorrectGuess == 0 && FirstTime)
                {
                    Console.WriteLine("The word is {0} Letters", Word.Length);
                    for (i = 0; i < Word.Length; i++)
                    {
                        if(Word[i] ==' ')
                            EmptyWord.Append('-');
                        else
                            EmptyWord.Append('_');
                    }
                    Console.WriteLine("{0}", EmptyWord);
                    RemainLettersToFind = Word.Length;
                }
                Console.WriteLine("Enter a letter to guess the word:");
                GuessLetter = Console.ReadLine();
                if(String.IsNullOrEmpty(GuessLetter))
                    throw new StringIsEmptyException("You didnt choose a letter");
                for (i=0;i< Word.Length ;i++ )
                {
                    if (GuessLetter[0] == Word[i])
                    {
                        EmptyWord[i] = GuessLetter[0];
                        FoundALetter = true;
                        CorrectGuess++;
                        RemainLettersToFind--;
                    }
                }
                if (!FoundALetter)
                {
                    PrintMan.Print_Man(errors++);
                }
                else
                    FoundALetter = false;
                UsedLetter.Add(GuessLetter);
                Console.WriteLine("used letters:");
                foreach (string c in UsedLetter)
                {
                    Console.WriteLine(string.Join(",", c[0]));
                }
                Console.WriteLine("Your word is :{0}", EmptyWord);
                FirstTime = false;
                if (RemainLettersToFind == 0)
                {
                    Console.WriteLine("Well Done! you finished the game! with {0} mistakes left", (Max_Num_Of_Tries - errors));
                    break;
                }
                if (Max_Num_Of_Tries == errors)
                {
                    Console.WriteLine("The Game is over.. Try again? :)");
                    break;
                }
            }

        }

    }
}
