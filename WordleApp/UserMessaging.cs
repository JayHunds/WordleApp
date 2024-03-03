﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace WordleApp
{
    internal class UserMessaging
    {
        public UserMessaging()
        {
            
        }

        public void WelcomeUser()
        {
            Console.WriteLine("Welcome to Wordle!");
            Console.WriteLine("Try to guess the secret five letter word.");
        }

        public void GuessCounter(int currentGuess, int maxGuess)
        {
            Console.WriteLine($"\nAttempt {currentGuess + 1}/{maxGuess}");
            Console.WriteLine("Enter your guess:");
        }
        public bool SucessCheck(string guess, string secretWord, int currentAttempt)
        {
            if (guess == secretWord)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Congratulations! You guessed the word: {secretWord} in {currentAttempt + 1} attempts!");
                Console.ResetColor();
            }
            return guess == secretWord;
        }
        public void FailMessage(int currentAttempt, int maxAttempts, string secretWord)
        {
            if (currentAttempt == maxAttempts)
            {
                Console.WriteLine($"\nSorry, you ran out of attempts. The secret word was: {secretWord}");
            }
        }
    }
}
