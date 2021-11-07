using System;
using System.Collections.Generic;

namespace Exercises
{
    public static class Skip
    {
        //Coding Exercise 1
        public static double CalculateAverageMark(Student student)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Coding Exercise 2
        public static IEnumerable<string> GetWordsBetweenStartAndEnd(List<string> words)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Refactoring challenge
        //TODO implement this method
        public static IEnumerable<int> GetAllAfterFirstDividableBy100_Refactored(
            IEnumerable<int> numbers)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //do not modify this method
        public static IEnumerable<int> GetAllAfterFirstDividableBy100(IEnumerable<int> numbers)
        {
            var result = new List<int>();
            bool startAdding = false;
            foreach (var number in numbers)
            {
                if (!startAdding && number % 100 == 0)
                {
                    startAdding = true;
                }
                if (startAdding)
                {
                    result.Add(number);
                }
            }
            return result;
        }

        public class Student
        {
            public IEnumerable<int> Marks { get; set; }
        }
    }
}
