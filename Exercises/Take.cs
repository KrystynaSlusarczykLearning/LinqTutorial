using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public static class Take
    {
        //Coding Exercise 1
        public static IEnumerable<int> TakeSome(IEnumerable<int> numbers)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Coding Exercise 2
        public static IEnumerable<Pet> GetGivenPercentOfHeaviestPets(
            IEnumerable<Pet> pets, int percent)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Refactoring challenge
        //TODO implement this method
        public static IEnumerable<DateTime> GetDatesBeforeXXCentury_Refactored(
            IEnumerable<DateTime> dates)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //do not modify this method
        public static IEnumerable<DateTime> GetDatesBeforeXXCentury(
            IEnumerable<DateTime> dates)
        {
            var result = new List<DateTime>();
            foreach (var date in dates)
            {
                if (date.Year < 1901)
                {
                    result.Add(date);
                }
                else
                {
                    break;
                }
            }
            return result;
        }

        public class Pet
        {
            public string Name { get; }
            public float Weight { get; }

            public Pet(string name, float weight)
            {
                Name = name;
                Weight = weight;
            }

            public override string ToString()
            {
                return $" Name: {Name}, Weight: {Weight}";
            }
        }
    }
}
