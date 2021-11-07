using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public static class Where
    {
        //Coding Exercise 1
        public static IEnumerable<Student> GetScholarshipCandidates(
            IEnumerable<Student> students)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Coding Exercise 2
        public static IEnumerable<string> GetProperlyIndexedWords(
            IEnumerable<string> words)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Refactoring challenge
        //TODO implement this method
        public static IEnumerable<Person> GetMultipleFishOwners_Refactored(
            IEnumerable<Person> people)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //do not modify this method
        public static IEnumerable<Person> GetMultipleFishOwners(
            IEnumerable<Person> people)
        {
            var result = new List<Person>();
            foreach (var person in people)
            {
                var count = 0;
                foreach (var pet in person.Pets)
                {
                    if (pet.PetType == PetType.Fish)
                    {
                        count++;
                    }
                }
                if (count > 1)
                {
                    result.Add(person);
                }
            }
            return result;
        }

        public class Student
        {
            public string Name { get; set; }
            public IEnumerable<int> Marks { get; set; }

            public override string ToString()
            {
                return $"{Name} with marks ({string.Join(", ", Marks)})";
            }
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

            public override string ToString()
            {
                return $"{Name} owns: ({string.Join(", ", Pets)})";
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
                return $"pet's name: {Name}, Type: {PetType}";
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
