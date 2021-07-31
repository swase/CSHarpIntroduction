using System;
using System.Collections.Generic;

namespace MoreTypes_Lib
{
    public class ArraysExercises
    {
        // returns a 1D array containing the contents of a given List
        public static string[] Make1DArray(List<string> contents)
        {
            string[] myStringArr = new string[contents.Count];

            for (int i = 0;i < myStringArr.Length;i++)
            {
                myStringArr[i] = contents[i];
            }
            return myStringArr;
 
        }

        // returns a 3D array containing the contents of a given List
        public static string[,,] Make3DArray(int length1, int length2, int length3, List<string> contents)
        {
            if (! (length1 * length2 * length3 == contents.Count))
            {
                throw new ArgumentException("Number of elements in list must match array size");
            }
            string[,,] stringArr = new string[length1, length2, length3];
            for (int i = 0; i < length1; i++)
            {
                for (int j = 0; j < length2; j++)
                {
                    for (int k = 0; k < length3; k++)
                    {
                        stringArr[i, j, k] = contents[(j * length2 + k) + (i * length2 * length3)];
                    }
                }
            }
            return stringArr;
        }

        // returns a jagged array containing the contents of a given List
        public static string[][] MakeJagged2DArray(int countRow1, int countRow2, List<string> contents)
        {
            string[][] myJaggedArr = new string[2][];
            if (countRow1 + countRow2 != contents.Count)
            {
                throw new ArgumentException("Number of elements in list must match array size");
            }

            else
            {
                myJaggedArr[0] = new string[countRow1];
                myJaggedArr[1] = new string[countRow2];
                
                for (int i = 0; i < countRow1; i++)
                {
                    myJaggedArr[0][i] = contents[i];
                }

                for (int j = 0; j < countRow2; j++)
                {
                    myJaggedArr[1][j] = contents[j + countRow1];
                }

            }
            return myJaggedArr;
        }
    }
}
