using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public static class JoinQuerySyntax
    {
        //Coding Exercise 1
        public static IEnumerable<string> GetStudentsInfo(
           IEnumerable<HogwartsStudent> students,
           IEnumerable<HogwartsHouse> houses)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Coding Exercise 2
        public static IEnumerable<string> GetHousesAndStudentsInfo(
                IEnumerable<HogwartsStudent> students,
                IEnumerable<HogwartsHouse> houses)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Refactoring challenge
        //TODO implement this method
        public static IEnumerable<string>
            GetSubjectsOfStudents_Refactored(
                IEnumerable<HogwartsStudent> students,
                IEnumerable<HogwartsSubject> subjects,
                IEnumerable<HogwartsHouse> houses)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //do not modify this method
        public static IEnumerable<string>
            GetSubjectsOfStudents(
                IEnumerable<HogwartsStudent> students,
                IEnumerable<HogwartsSubject> subjects,
                IEnumerable<HogwartsHouse> houses)
        {
            var result = new List<string>();
            foreach (var student in students)
            {
                string studentHouse = null;
                foreach (var house in houses)
                {
                    if (house.Id == student.HouseId)
                    {
                        studentHouse = house.Name;
                    }
                }

                foreach (var subjectId in student.SubjectsIds)
                {
                    foreach (var subject in subjects)
                    {
                        if (subject.Id == subjectId)
                        {
                            result.Add($"{student.Name} from house" +
                                $" {studentHouse} " +
                                $"studies {subject.Name}");
                        }
                    }
                }
            }
            return result;
        }

        public class HogwartsHouse
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public override string ToString()
            {
                return $"{Id}:{Name}";
            }
        }

        public class HogwartsStudent
        {
            public IEnumerable<int> SubjectsIds { get; set; }
            public int HouseId { get; set; }
            public string Name { get; set; }

            public override string ToString()
            {
                return $"{Name} (House:{HouseId}) studies {string.Join(", ", SubjectsIds)}";
            }
        }

        public class HogwartsSubject
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public override string ToString()
            {
                return $"{Id}:{Name}";
            }
        }
    }
}
