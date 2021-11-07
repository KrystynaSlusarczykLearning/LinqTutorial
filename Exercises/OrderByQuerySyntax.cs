using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public static class OrderByQuerySyntax
    {
        //Coding Exercise 1
        public static IEnumerable<TimeSpan>
            OrderFromLongestToShortest(
                IEnumerable<TimeSpan> timeSpans)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Coding Exercise 2
        public static IEnumerable<Point> OrderPoints(
             IEnumerable<Point> points)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Refactoring challenge
        //TODO implement this method
        public static IEnumerable<DateTime>
            OrderDatesByDayOfWeek_Refactored(
                IEnumerable<DateTime> dates)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //do not modify this method
        public static IEnumerable<DateTime>
            OrderDatesByDayOfWeek(
                IEnumerable<DateTime> dates)
        {
            var result = dates.ToList();
            result.Sort((left, right) =>
            {
                return left.DayOfWeek.CompareTo(right.DayOfWeek);
            });
            return result;
        }

        public struct Point
        {
            public double X { get; }
            public double Y { get; }

            public Point(double x, double y)
            {
                X = x;
                Y = y;
            }

            public override string ToString()
            {
                return $"X: {X}, Y: {Y}";
            }
        }
    }
}
