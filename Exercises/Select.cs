using System;
using System.Collections.Generic;

namespace Exercises
{
    public static class Select
    {
        //Coding Exercise 1
        public static IEnumerable<int> GetNumbers(IEnumerable<object> objects)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Coding Exercise 2
        public static IEnumerable<Person> PeopleFromString(string input)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Refactoring challenge
        //TODO implement this method
        public static TimeSpan TotalDurationOfSongs_Refactored(string allSongsDuration)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //do not modify this method
        public static TimeSpan TotalDurationOfSongs(
            string allSongsDuration)
        {
            if (string.IsNullOrEmpty(allSongsDuration))
            {
                return new TimeSpan();
            }

            var durationStrings = allSongsDuration.Split(',');
            var totalDuration = 0d;
            foreach (var durationString in durationStrings)
            {
                var timeSpan = TimeSpan.ParseExact(
                    durationString, @"m\:ss", null);
                totalDuration += timeSpan.TotalSeconds;
            }

            return TimeSpan.FromSeconds(totalDuration);
        }

        public class Person : IEquatable<Person>
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime DateOfBirth { get; set; }

            public override string ToString()
            {
                return $"{FirstName} {LastName} born on {DateOfBirth.ToString("d")}";
            }

            public bool Equals(Person other)
            {
                return FirstName == other.FirstName &&
                       LastName == other.LastName &&
                       DateOfBirth == other.DateOfBirth;
            }
        }
    }
}
