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
     GamePlayLoop executor = new GamePlayLoop();
        executor.ExecuteGame(new UserMessaging());
    }
}

