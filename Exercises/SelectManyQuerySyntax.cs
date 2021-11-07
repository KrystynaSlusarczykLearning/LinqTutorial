using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public static class SelectManyQuerySyntax
    {
        //Coding Exercise 1
        public static IEnumerable<string> GetStudentMarksInfo(
            IEnumerable<Student> students)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Coding Exercise 2
        public static IEnumerable<Tuple<int, int>>
            SelectAllCombinationsWithSumBelow100(
                IEnumerable<int> numbers1,
                IEnumerable<int> numbers2)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Refactoring challenge
        //TODO implement this method
        public static IEnumerable<string>
            GetDivisorsInfo_Refactored(
                IEnumerable<int> numbers)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //do not modify this method
        public static IEnumerable<string>
            GetDivisorsInfo(
                IEnumerable<int> numbers)
        {
            var orderedNumbers = numbers.ToList();
            orderedNumbers.Sort();
            var result = new List<string>();
            foreach (var number in orderedNumbers)
            {
                var divisors = GetDivisors(number).ToList();
                divisors.Sort();
                foreach (var divisor in divisors)
                {
                    result.Add(
                        $"Number {number} is " +
                        $"divisible by {divisor}");
                }
            }
            return result;
        }

        private static IEnumerable<int> GetDivisors(int number)
        {
            return from potentialDivisor in
                       Enumerable.Range(
                           1,
                           number)
                   where number % potentialDivisor == 0
                   select potentialDivisor;
        }

        public class Student
        {
            public string Name { get; set; }
            public IEnumerable<int> Marks { get; set; }

            public override string ToString()
            {
                var marks = Marks != null ? $"({string.Join(", ", Marks)})" : "null";
                return $"{Name} with marks: {marks})";
            }
        }
    }
}
