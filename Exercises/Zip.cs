using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public static class Zip
    {
        //Coding Exercise 1
        public static IEnumerable<DateTime> BuildDates(
            IEnumerable<int> years,
            IEnumerable<int> months,
            IEnumerable<int> days)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Coding Exercise 2
        public static IEnumerable<string>
            GetDaysDifferencesBetweenDates(
                IEnumerable<DateTime> dates)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Refactoring challenge
        //TODO implement this method
        public static IEnumerable<string> MakeList_Refactored(IEnumerable<string> words)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //do not modify this method
        public static IEnumerable<string> MakeList(IEnumerable<string> words)
        {
            var result = new List<string>();
            char letter = 'A';
            foreach (var word in words)
            {
                result.Add($"{letter}) {word}");
                letter++;
            }
            return result;
        }
    }
}
