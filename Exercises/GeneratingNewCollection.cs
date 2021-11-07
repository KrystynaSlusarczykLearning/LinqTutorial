using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public static class GeneratingNewCollection
    {
        //Coding Exercise 1
        public static Dictionary<int, string> NewYearsEvesSince(
            int initialYear, int yearsCount)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Coding Exercise 2
        public static string BuildTree(int levels)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Refactoring challenge
        //TODO implement this method
        public static IEnumerable<string> DoubleLetters_Refactored(int countOfLetters)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //do not modify this method
        public static IEnumerable<string> DoubleLetters(int countOfLetters)
        {
            const int CountOfLettersInEnglishAlphabet = 26;
            var finalCountOfLetters = Math.Min(
                countOfLetters,
                CountOfLettersInEnglishAlphabet);

            var allLetters = new List<char>();
            var letter = 'A';
            for (int i = 0; i < finalCountOfLetters; ++i)
            {
                allLetters.Add(letter);
                letter++;
            }

            var result = new List<string>();
            foreach (var firstLetter in allLetters)
            {
                foreach (var secondLetter in allLetters)
                {
                    result.Add($"{firstLetter}{secondLetter}");
                }
            }
            return result;
        }
    }
}
