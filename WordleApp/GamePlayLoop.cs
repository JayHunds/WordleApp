using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WordleApp
{
    internal class GamePlayLoop
    {
        public GamePlayLoop()
        {

        }
        public void ExecuteGame(UserMessaging messanger)
        {
            string[] wordList = { "HELLO", "WORLD", "FINDS", "EARTH", "ENZYM", "JUKED", "APPLE", "HOUSE", "OCEAN", "TIGER" };
            int maxAttempts = 6;
            int currentAttempt = 0;
            WordSelector wordSelector = new WordSelector(wordList);

            string secretWord = wordSelector.SelectRandomWord();
            messanger.WelcomeUser();
            while (currentAttempt < maxAttempts)
            {
                messanger.GuessCounter(currentAttempt, maxAttempts);

                string guess = Console.ReadLine().ToUpper();
                Console.WriteLine();

                bool IsSucess = messanger.SucessCheck(guess, secretWord, currentAttempt);
                if (IsSucess) { break; }

                FeedBackGenerator feedBackGenerator = new FeedBackGenerator();
                feedBackGenerator.validateGuess(secretWord, guess);

                Console.ResetColor();
                Console.WriteLine();

                currentAttempt++;
            }
            messanger.FailMessage(currentAttempt, maxAttempts, secretWord);
        }
    }
}
