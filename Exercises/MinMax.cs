using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public static class MinMax
    {
        //Coding Exercise 1
        public static int? LengthOfTheShortestWord(IEnumerable<string> words)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Coding Exercise 2
        public static int CountOfLargestNumbers(IEnumerable<int> numbers)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Refactoring challenge
        //TODO implement this method
        public static int CountOfDogsOfTheOwnerWithMostDogs_Refactored(
            IEnumerable<Person> owners)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //do not modify this method
        public static int CountOfDogsOfTheOwnerWithMostDogs(IEnumerable<Person> owners)
        {
            var maxDogCount = 0;
            foreach (var owner in owners)
            {
                var dogsCount = 0;
                foreach (var pet in owner.Pets)
                {
                    if (pet.PetType == PetType.Dog)
                    {
                        dogsCount++;
                    }
                }
                if (dogsCount > maxDogCount)
                {
                    maxDogCount = dogsCount;
                }
            }
            return maxDogCount;
        }

        public class Person
        {
            public int Id { get; }
            public string Name { get; }
            public IEnumerable<Pet> Pets;

            public Person(int id, string name, IEnumerable<Pet> pets)
            {
                Id = id;
                Name = name;
                Pets = pets;
            }
        }

        public class Pet
        {
            public int Id { get; }
            public string Name { get; }
            public PetType PetType { get; }
            public float Weight { get; }

            public Pet(int id, string name, PetType petType, float weight)
            {
                Id = id;
                Name = name;
                PetType = petType;
                Weight = weight;
            }

            public override string ToString()
            {
                return $"Id: {Id}, Name: {Name}, Type: {PetType}";
            }
        }

        public enum PetType
        {
            Cat,
            Dog,
            Fish
        }
    }
}
