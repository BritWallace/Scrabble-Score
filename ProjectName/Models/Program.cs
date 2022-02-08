using System;
using System.Collections.Generic;
using Scrabble.Logic;

namespace Scrabble
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("We are gonna score some scrabble tiles! Enter your word: ");
            string scrabbleWord = Console.ReadLine();
            //This is just a test to see if the writeline will output 'e'
            string testWord = "letters";
            Console.WriteLine(testWord[1]);
        }
    }
}