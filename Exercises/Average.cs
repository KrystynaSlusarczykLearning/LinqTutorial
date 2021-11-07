using System;
using System.Collections.Generic;

namespace Exercises
{
    public static class Average
    {
        //Coding Exercise 1
        public static float? AverageSnowFall(SnowFallData snowFallData)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Coding Exercise 2
        public static double MaxAverageOfMarks(IEnumerable<Student> students)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Refactoring challenge
        //TODO implement this method
        public static float CalculateAverageHeight_Refactored(
            List<float?> heights, float defaultIfNull)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //do not modify this method
        public static float CalculateAverageHeight(
            List<float?> heights, float defaultIfNull)
        {
            if (heights == null || heights.Count == 0)
            {
                return 0;
            }
            var sum = 0f;
            foreach (var height in heights)
            {
                if (height == null)
                {
                    sum += defaultIfNull;
                }
                else
                {
                    sum += height.Value;
                }
            }
            return sum / heights.Count;
        }

        public class Student
        {
            public IEnumerable<int> Marks { get; set; }
        }

        public class SnowFallData
        {
            public int Year { get; set; }
            public List<MonthlySnowFallData> MonthlySnowFallDataItems { get; set; }
        }

        public class MonthlySnowFallData
        {
            public int Month { get; set; }
            public float SnowfallInCentimeters { get; set; }
        }
    }
}
