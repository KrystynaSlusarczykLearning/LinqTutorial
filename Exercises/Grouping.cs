using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public static class Grouping
    {
        //Coding Exercise 1
        public static char? GetTheMostFrequentCharacter(string text)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Coding Exercise 2
        public static PetType? FindTheHeaviestPetType(IEnumerable<Pet> pets)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Refactoring challenge
        //TODO implement this method
        public static IEnumerable<string> CountPets_Refactored(string petsData)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //do not modify this method
        public static IEnumerable<string> CountPets(string petsData)
        {
            if (string.IsNullOrEmpty(petsData))
            {
                return new string[0];
            }
            var pets = petsData.Split(',');
            var petsCountsDictionary = new Dictionary<string, int>();
            foreach (var pet in pets)
            {
                if (!petsCountsDictionary.ContainsKey(pet))
                {
                    petsCountsDictionary[pet] = 0;
                }
                petsCountsDictionary[pet]++;
            }
            var result = new List<string>();
            foreach (var petCount in petsCountsDictionary)
            {
                result.Add($"{petCount.Key}:{petCount.Value}");
            }
            return result;
        }

        public class Pet
        {
            public string Name { get; }
            public PetType PetType { get; }
            public float Weight { get; }

            public Pet(string name, PetType petType, float weight)
            {
                Name = name;
                PetType = petType;
                Weight = weight;
            }

            public override string ToString()
            {
                return $"Name: {Name}, Type: {PetType}, Weight: {Weight}";
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
