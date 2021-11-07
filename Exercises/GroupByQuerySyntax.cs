using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public static class GroupByQuerySyntax
    {
        //Coding Exercise 1
        public static IEnumerable<string> GroupByFirstDigit(IEnumerable<int> numbers)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Coding Exercise 2
        public static Dictionary<DayOfWeek, DateTime> GroupByDayOfWeek(
            IEnumerable<DateTime> dates)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Refactoring challenge
        //TODO implement this method
        public static IEnumerable<string> GetOwnersWithMultipleHouses_Refactored(
            IEnumerable<House> houses)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //do not modify this method
        public static IEnumerable<string>
            GetOwnersWithMultipleHouses(
                IEnumerable<House> houses)
        {
            var ownersHouses = new Dictionary<int, List<House>>();
            foreach (var house in houses)
            {
                if (!ownersHouses.ContainsKey(house.OwnerId))
                {
                    ownersHouses[house.OwnerId] = new List<House>();
                }
                ownersHouses[house.OwnerId].Add(house);
            }

            var result = new List<string>();
            foreach (var keyValue in ownersHouses)
            {
                if (keyValue.Value.Count > 1)
                {
                    result.Add(
                        $"Owner with ID {keyValue.Key} " +
                        $"owns houses: " +
                        $"{string.Join(", ", keyValue.Value)}");
                }
            }
            return result;
        }

        public class House
        {
            public int OwnerId { get; }
            public string Address { get; }

            public House(int ownerId, string address)
            {
                OwnerId = ownerId;
                Address = address;
            }

            public override string ToString()
            {
                return $"{Address}";
            }
        }
    }
}
