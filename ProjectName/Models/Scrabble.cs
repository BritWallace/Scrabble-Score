using System;
using System.Collections.Generic;
using Scrabble;

namespace Scrabble.Logic
{
    public class ScrabbleGame
    {
        public static int Score(string scrabbleWord)
        {
            string scrabbleWordToScore = scrabbleWord;
            int totalScore = 0;

            for (int i = 0; i < scrabbleWordToScore.Length; i++)
            //string[] onePointers = {'a', 'e', 'i'};
            {
            char[] onePointers = {'a', 'e', 'i'};
            // What does => ? 
            if ((Array.Exists<char>( onePointers, element => element == scrabbleWordToScore[i])))

                {
                    totalScore =+ 1;
                }
            }

            return totalScore;
        }
    }
}

// Inputted word will be taken in
// Inputted word will be split to individual letters ("Add" returns "a/d/d")
// Set scores of individual letters
// Add up integers assigned to individual letters (If a and d = 1, expected output is 3)
// A, E, I, O, U, L, N, R, S, T       1
// D, G                               2
// B, C, M, P                         3
// F, H, V, W, Y                      4
// K                                  5
// J, X                               8
// Q, Z                               10