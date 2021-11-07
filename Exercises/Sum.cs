using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public static class Sum
    {
        //Coding Exercise 1
        public static int TotalLength(IEnumerable<string> words)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Coding Exercise 2
        public static double AverageSum(
            IEnumerable<IEnumerable<int>> collectionsOfNumbers)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Refactoring challenge
        //TODO implement this method
        public static bool HasAnyStudentSumOfMarksLargerThan100_Refactored(
            IEnumerable<Student> students)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //do not modify this method
        public static bool HasAnyStudentSumOfMarksLargerThan100(
            IEnumerable<Student> students)
        {
            foreach (var student in students)
            {
                var sumOfMarks = 0;
                foreach (var mark in student.Marks)
                {
                    sumOfMarks += mark;
                }
                if (sumOfMarks > 100)
                {
                    return true;
                }
            }
            return false;
        }

        public class Student
        {
            public IEnumerable<int> Marks { get; set; }
        }
    }
}
