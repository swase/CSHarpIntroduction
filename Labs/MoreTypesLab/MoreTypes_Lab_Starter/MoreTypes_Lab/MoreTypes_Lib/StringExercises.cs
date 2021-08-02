using System;
using System.Text;

namespace MoreTypes_Lib
{
    public class StringExercises
    {
        // manipulates and returns a string - see the unit test for requirements
        public static string ManipulateString(string input, int num)
        {
            var outputString = new StringBuilder(input.Trim().ToUpper());
            for (int i = 0; i < num; i++)
            {
                outputString.Append(i);
            }
            return outputString.ToString();
        }

        // returns a formatted address string given its components
        public static string Address(int number, string street, string city, string postcode)
        {
            return $"{number} {street}, {city} {postcode}.";
        }
        // returns a string representing a test score, written as percentage to 1 decimal place
        public static string Scorer(int score, int outOf)
        {
            return $"You got {score} out of {outOf}: {score / ((float) outOf) * 100 :f1}%";
        }

        // returns the double represented by the string, or -999 if conversion is not possible
        public static double ParseNum(string numString)
        {
            double res;
            if (Double.TryParse(numString, out res))
            {
                return Convert.ToDouble(numString);
            }
             else 
            {
                return -999;
            }
        }

        // Returns the a string containing the count of As, Bs, Cs and Ds in the parameter string
        // all other letters are ignored
        public static string CountLetters(string input)
        {
            int[] count = new int[] { 0, 0, 0, 0 };     //Count of 0:A 1:B 2:C, 3:D
            foreach(var element in input)
            {
                switch(element)
                {
                    case 'A':
                        count[0]++;
                        break;
                    case 'B':
                        count[1]++;
                        break;
                    case 'C':
                        count[2]++;
                        break;
                    case 'D':
                        count[3]++;
                        break;
                    default:
                        break;
                }
            }
            return $"A:{count[0]} B:{count[1]} C:{count[2]} D:{count[3]}";
        }
    }
}
