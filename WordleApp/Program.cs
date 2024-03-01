// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using WordleApp;

class Program
{
    static void Main(string[] args)
    {
        string[] wordList = { "HELLO", "WORLD", "FINDS", "EARTH", "ENZYM", "JUKED", "APPLE", "HOUSE", "OCEAN", "TIGER" };
        Random random = new Random();

        int randomIndex = random.Next(0, wordList.Length);

        string secretWord = wordList[randomIndex];
        int maxAttempts = 6;
        int currentAttempt = 0;

        Console.WriteLine("Welcome to Wordle!");
        Console.WriteLine("Try to guess the secret five letter word.");

        // Main game loop
        while (currentAttempt < maxAttempts)
        {
            Console.WriteLine($"\nAttempt {currentAttempt + 1}/{maxAttempts}");
            Console.WriteLine("Enter your guess:");

            string guess = Console.ReadLine().ToUpper();
            Console.WriteLine();

            if (guess == secretWord)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Congratulations! You guessed the word: {secretWord} in {currentAttempt + 1} attempts!");
                Console.ResetColor();
                break;
            }

            Console.WriteLine("Feedback:");
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

            Console.ResetColor();
            Console.WriteLine();

            currentAttempt++;
        }
        if (currentAttempt == maxAttempts)
        {
            Console.WriteLine($"\nSorry, you ran out of attempts. The secret word was: {secretWord}");
        }
    }
}

