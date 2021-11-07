using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public static class FirstLast
    {
        //Coding Exercise 1
        public static string FindFirstNameInTheCollection(IEnumerable<string> words)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Coding Exercise 2
        public static Person GetYoungest(IEnumerable<Person> people)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Refactoring challenge
        //TODO implement this method
        public static Person FindOwnerOf_Refactored(Pet pet, IEnumerable<Person> people)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //do not modify this method
        public static Person FindOwnerOf(Pet pet, IEnumerable<Person> people)
        {
            foreach (var person in people)
            {
                foreach (var personsPet in person.Pets)
                {
                    if (personsPet == pet)
                    {
                        return person;
                    }
                }
            }
            return null;
        }

        public class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public IEnumerable<Pet> Pets;
            public DateTime DateOfBirth { get; set; }

            public Person(string name, DateTime dateOfBirth)
            {
                Name = name;
                DateOfBirth = dateOfBirth;
            }

            public Person(int id, string name, IEnumerable<Pet> pets)
            {
                Id = id;
                Name = name;
                Pets = pets;
            }

            public override string ToString()
            {
                return $"Name: {Name}, DateOfBirth: {DateOfBirth}";
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
                return $"Id: {Id}, Name: {Name}, Type: {PetType}, Weight: {Weight}";
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
