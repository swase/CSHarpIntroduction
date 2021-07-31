using System;

namespace MoreDataTypesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(StringExercise("C# List Fundamentals"));

            //Parsing input and converting input data type

            //Console.WriteLine("How do you like them apples?");
            //int input = Int32.Parse(Console.ReadLine());
            //Console.WriteLine(input.GetType());
            //var success = Int32.TryParse(Console.ReadLine(), out int numApples);      //success is type bool

            //Arrays
            int[,] myIntArray = new int[,] { { 1, 2 }, { 3, 4 }, {5, 6}, { 7, 8 }};
            Print2dArray(myIntArray);

        }
        public static string StringBuilderExercise(string myString)
        {
            return "";
        }
        public static string StringExercise(string myString)
        {
            myString = myString.Trim().ToUpper().Replace('L', '*').Replace('T', '*');
            return myString.Remove(myString.IndexOf('N') + 1);
        }

        public static void MultiDArray()
        {
            int[,] array2D = new int[,] {  { 1, 2 },
                        { 3, 4 },
                        { 5, 6 },
                        { 7, 8 } };
        }

        public static void Print2dArray(int[,] myArray)
        {
            for (int i = 0; i < myArray.GetLength(0) ; i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write($"({i}, {j}): {myArray[i,j]}, ");
                }
                Console.WriteLine("");
            }

        }
    }
}
