using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public static class Distinct
    {
        //Coding Exercise 1
        public static bool AreAllUnique<T>(IEnumerable<T> collection)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Coding Exercise 2
        public static IEnumerable<T> GetCollectionWithMostDuplicates<T>(
            IEnumerable<IEnumerable<T>> collections)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Refactoring challenge
        //TODO implement this method
        public static IEnumerable<string> GetWordsShorterThan5Letters_Refactored(
            IEnumerable<string> words)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //do not modify this method
        public static IEnumerable<string> GetWordsShorterThan5Letters(
            IEnumerable<string> words)
        {
            var result = new List<string>();
            foreach (var word in words)
            {
                if (word.Length < 5 && !result.Contains(word))
                {
                    result.Add(word);
                }
            }
            return result;
        }
    }
}
