using System;
using System.Collections.Generic;

namespace Exercises
{
    public static class OfType
    {
        //Coding Exercise 1
        public static int? GetTheFirstInteger(IEnumerable<object> objects)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Coding Exercise 2
        public static bool AreAllStringsUpperCase(IEnumerable<object> objects)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //Refactoring challenge
        //TODO implement this method
        public static DateTime? GetTheLatestDate_Refactored(IEnumerable<object> objects)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }

        //do not modify this method
        public static DateTime? GetTheLatestDate(IEnumerable<object> objects)
        {
            DateTime? lastDate = null;
            foreach (var obj in objects)
            {
                var dateTime = obj as DateTime?;
                if (dateTime != null)
                {
                    if (lastDate == null || lastDate < dateTime)
                    {
                        lastDate = dateTime;
                    }
                }
            }
            return lastDate;
        }
    }
}
