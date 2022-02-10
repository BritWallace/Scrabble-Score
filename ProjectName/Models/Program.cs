using System;
using System.Collections.Generic;
using Scrabble.Logic;
using Classy;

namespace Scrabble
{
    public class Program
    {
        public static void Main()
        {
            //The below 3 lines are just to test out using getters and setters
            // ScrabbleGame newGame = new ScrabbleGame("Olive");
            // Console.WriteLine(newGame.scrabbleWordToScore2);
            // Console.WriteLine(newGame.scrabbleWord2);

            Console.Write("Enter your name so we can class it up: ");
            string name = Console.ReadLine();
            Console.WriteLine(KeepItClassy.whoIsClassy(name));
            Console.Write("We are gonna score some scrabble tiles! Enter your word: ");
            string scrabbleWord = Console.ReadLine();
            //string lowerCaseWord = scrabbleWord.ToLower();
            double total = ScrabbleGame.Score(scrabbleWord);
            Console.WriteLine("Total: {0:C}\n", total);
            Console.WriteLine("└(=^‥^=)┘");

        }
    }
}