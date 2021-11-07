using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public static class Join
    {
        //Coding Exercise 1
        public static IEnumerable<string> GetHouseOwnersData(
             IEnumerable<Person> people,
             IEnumerable<House> houses)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Coding Exercise 2
        public static IEnumerable<string> GetOrdersData(
            IEnumerable<Customer> customers,
            IEnumerable<Item> items,
            IEnumerable<Order> orders)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Refactoring challenge
        //TODO implement this method
        public static Dictionary<House, Person> GetHousesData_Refactored(
            IEnumerable<Person> people,
            IEnumerable<House> houses)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //do not modify this method
        public static Dictionary<House, Person> GetHousesData(
            IEnumerable<Person> people,
            IEnumerable<House> houses)
        {
            var result = new Dictionary<House, Person>();
            foreach (var house in houses)
            {
                foreach (var owner in people)
                {
                    if (owner.Id == house.OwnerId)
                    {
                        result[house] = owner;
                    }
                }
            }
            return result;
        }

        public class House
        {
            public int OwnerId { get; }
            public string Adderss { get; }

            public House(int ownerId, string adderss)
            {
                OwnerId = ownerId;
                Adderss = adderss;
            }

            public override string ToString()
            {
                return $"(OwnerId: {OwnerId}) {Adderss}";
            }
        }

        public class Person
        {
            public int Id { get; }
            public string Name { get; }

            public Person(int id, string name)
            {
                Id = id;
                Name = name;
            }

            public override string ToString()
            {
                return $"(Id:{Id}), {Name}";
            }
        }

        public class Customer
        {
            public int Id { get; }
            public string Name { get; }

            public Customer(int id, string name)
            {
                Id = id;
                Name = name;
            }

            public override string ToString()
            {
                return $"Id: {Id}, Name: {Name}";
            }
        }

        public class Order
        {
            public int CustomerId { get; }
            public int ItemId { get; }
            public int Count { get; }

            public Order(int customerId, int itemId, int count)
            {
                CustomerId = customerId;
                ItemId = itemId;
                Count = count;
            }

            public override string ToString()
            {
                return $"CustomerId: {CustomerId}, ItemId: {ItemId}, Count: {Count}";
            }
        }

        public class Item
        {
            public int Id { get; }
            public string Name { get; }

            public Item(int id, string name)
            {
                Id = id;
                Name = name;
            }

            public override string ToString()
            {
                return $"Id: {Id}, Name: {Name}";
            }
        }
    }
}
