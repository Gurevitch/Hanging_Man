using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Hanging_man
{
    class GameChar
    {
        public char WordChar { get; set; }
        public bool CharUsedOrNot { get; set; }
        public GameChar(char ch)
        {
            CharUsedOrNot = false;
            WordChar = ch;
        }
    }
    public class Game
    {
        #region Members
        private int _errors = 0;
        private List<GameChar> _wordGuess; 
        private string _gameWord;
        private const int MAX_ERRORGUESSES = 12;
        private HangingMenPrinter _printer;
        private readonly HashSet<char> _letterList = new HashSet<char>();
        #endregion Members

        public Game(HangingMenPrinter printer)
        {
            _printer = printer;
        }
        private string GetLevelFromWeb()
        {
            string[] lines;
            var rand = new Random();
            var ListOfFoundWords = new List<string>();

            lines = System.IO.File.ReadAllLines(@"https://ischoolconnect.com/blog/60-new-words-in-english-with-meanings/");
            foreach (var line in lines)
            {
                if (File.Exists(line))
                {
                }
            }
            var WordIndexToReturn = rand.Next(ListOfFoundWords.Capacity);
            return ListOfFoundWords[WordIndexToReturn];
        }
        private void InitWord()
        {
            #region LocalMembers
            int level = 0;
            string word;
            Console.WriteLine("Welcome! to start choose the level to the game you want, \n 1 = easy 2 = medium and 3 = hard 4 = new word");
            word = Console.ReadLine();
            level = Int32.Parse(word);
            #endregion
            try
            {
                switch (level)
                {
                    case 1:
                        _gameWord =  "house";
                        break;
                    case 2:
                        _gameWord = "happiness";
                        break;
                   case 3:
                        _gameWord = "tottenham hotspurs";
                        break;
                    case 4:
                        {
                            _gameWord = GetLevelFromWeb();
                            break;
                        }
                    default:
                        throw new ArgumentOutOfRangeException("Unknown value");
                }
            }
            catch
            {
                throw new StringIsEmptyException("the string was empty or null");
            }

            _wordGuess = Enumerable.Range(0, _gameWord.Length).Select(num => new GameChar(_gameWord[num])).ToList();
        }
        private (char,bool) GetLetters()
        {
            char charFromUser ;
            bool charGuess = false;

            charFromUser = Console.ReadKey().KeyChar;
            Console.WriteLine("");
            charGuess = false;
            foreach(var wordChar in _wordGuess)
            {
                if ((!wordChar.CharUsedOrNot) && charFromUser ==wordChar.WordChar)
                { 
                    wordChar.CharUsedOrNot = true;
                    charGuess = true;
                    break;
                }
            };

            return (charFromUser,charGuess);
        }
        public class StringIsEmptyException : Exception
        {
            public StringIsEmptyException(string message) : base(message)
            {
            }
        }
        public void Start()
        {
            InitWord();
            string wordToPrint = string.Join(" ", _wordGuess.Select(gamechar => gamechar.CharUsedOrNot ? gamechar.WordChar : '_'));
            Console.WriteLine(wordToPrint);
            while (_errors < MAX_ERRORGUESSES && _wordGuess.Any(wordchar => !wordchar.CharUsedOrNot))
            {
               (char charFromUser,bool isGuessed) =  GetLetters();
                if (!isGuessed)
                {
                    _printer.PrintMan(++_errors);
                    _letterList.Add(charFromUser);
                }
                wordToPrint = string.Join(" ",_wordGuess.Select(gamechar => gamechar.CharUsedOrNot? gamechar.WordChar : '_'));

                Console.WriteLine(wordToPrint);
                Console.WriteLine(string.Join(", ",_letterList ));
            }
            if (_wordGuess.All(wordchar => wordchar.CharUsedOrNot))
            {
                Console.WriteLine("WHhoh you finished the game!!!");
            }
            else
            {
                Console.WriteLine("maybe next time..");
            }
        }
    }
}
