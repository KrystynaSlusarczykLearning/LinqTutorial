using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public static class SelectMany
    {
        //Coding Exercise 1
        public static IEnumerable<string> BuildCartesianProduct(
            HashSet<int> numbers)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Coding Exercise 2
        public static IEnumerable<string> BestMarksAndStudents(
            IEnumerable<Student> students)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Refactoring challenge
        //TODO implement this method
        public static Dictionary<string, double> SegmentsLengths_Refactored(
            IEnumerable<Point> starts, IEnumerable<Point> ends)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //do not modify this method
        public static Dictionary<string, double> SegmentsLengths(
            IEnumerable<Point> starts, IEnumerable<Point> ends)
        {
            var result = new Dictionary<string, double>();
            foreach (var startPoint in starts)
            {
                foreach (var endPoint in ends)
                {
                    var length = SegmentLength(startPoint, endPoint);
                    var key = $"Start: ({startPoint}), End: ({endPoint})";
                    result[key] = length;
                }
            }
            return result;
        }

        public static double SegmentLength(Point start, Point end)
        {
            return Math.Sqrt((Math.Pow(start.X - end.X, 2) + Math.Pow(start.Y - end.Y, 2)));
        }

        public class Student
        {
            public string Name { get; set; }
            public IEnumerable<int> Marks { get; set; }

            public override string ToString()
            {
                return $"{Name} with marks ({string.Join(",", Marks)})";
            }
        }

        public struct Point
        {
            public double X { get; set; }
            public double Y { get; set; }

            public override string ToString()
            {
                return $"X: {X}, Y: {Y}";
            }
        }
    }
}
