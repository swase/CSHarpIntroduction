using System;
using System.Collections.Generic;
using System.Globalization;

namespace Collections_Lib
{
    public class ListExercises
    {
        // returns a list of all the integers between 1 to max inclusive
        // that are multiples of 5
        public static List<int> MakeFiveList(int max)
        {
            var multiplesOfFive = new List<int>();
            for (int i = 1; i <= max; i++)
            {
                if (i % 5 == 0)
                {
                    multiplesOfFive.Add(i);
                }
            }
            return multiplesOfFive;
        }

        // returns a list of all the strings in sourceList that start with the letter 'A' or 'a'
        public static List<string> MakeAList(List<string> sourceList)
        {
            var stringsStartingWithA = new List<string>();
            
            if (sourceList.Count == 0)
            {
                return stringsStartingWithA;
            }
            foreach(string element in sourceList)
            {
                var ci = new CultureInfo("en-US");
                if (element.StartsWith("A", true,ci))
                {
                    stringsStartingWithA.Add(element);
                }
            }
            return stringsStartingWithA;
        }
    }
}
