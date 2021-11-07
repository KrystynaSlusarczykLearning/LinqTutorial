using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public static class ElementAt
    {
        //Coding Exercise 1
        public static bool IsTheNumberAtIndexTheLargest(
            IEnumerable<int> numbers, int index)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Coding Exercise 2
        public static string FormatPetDataAtIndex(
            IEnumerable<Pet> pets, int index)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Refactoring challenge
        //TODO implement this method
        public static bool IsEmptyAtIndex_Refactored(IEnumerable<string> words, int index)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //do not modify this method
        public static bool IsEmptyAtIndex(IEnumerable<string> words, int index)
        {
            var array = words.ToArray();
            if (index < 0 || index >= array.Length)
            {
                return true;
            }
            if (string.IsNullOrEmpty(array[index]))
            {
                return true;
            }
            return false;
        }

        public class Pet
        {
            public string Name { get; set; }
        }
    }
}
