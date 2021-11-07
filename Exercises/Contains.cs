using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public static class Contains
    {
        //Coding Exercise 1
        public static bool IsAppointmentDateAvailable(
            DateTime date, IEnumerable<DateTime> existingAppointmentDates)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Coding Exercise 2
        public static int CountFriendsOf(Friend friend, IEnumerable<Person> people)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Refactoring challenge
        //TODO implement this method
        public static bool ContainsBannedWords_Refactored(
            IEnumerable<string> words, IEnumerable<string> bannedWords)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //do not modify this method
        public static bool ContainsBannedWords(
            IEnumerable<string> words, IEnumerable<string> bannedWords)
        {
            foreach (var word in words)
            {
                foreach (var bannedWord in bannedWords)
                {
                    if (word == bannedWord)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public class Person
        {
            public string Name { get; }
            public IEnumerable<Friend> Friends { get; }

            public Person(string name, IEnumerable<Friend> friends)
            {
                Name = name;
                Friends = friends;
            }
        }

        public class Friend
        {
            public string Name { get; }
        }
    }
}
