using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WordleApp
{
    internal class FeedBackGenerator
    {

        public FeedBackGenerator()
        {

        }

        public void validateGuess(string secretWord, string guess)
        {
            Console.WriteLine("Feedback:");
            if (guess.Length == secretWord.Length)
            {
                feedbackLoop(guess, secretWord);
            }
            else if (guess.Length < secretWord.Length)
            {
                feedbackLoop(guess, secretWord);
            }
        }    
        public void feedbackLoop(string guess, string secretWord)
        {
            for (int i = 0; i < guess.Length; i++)
            {
                char currentLetterOfGuess = guess[i];
                if (secretWord.Contains(currentLetterOfGuess) && secretWord[i] == currentLetterOfGuess)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(currentLetterOfGuess);
                }
                else if (secretWord.Contains(currentLetterOfGuess) && secretWord[i] != currentLetterOfGuess)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(guess[i]);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(currentLetterOfGuess);
                }
            }
        }
    }
}
