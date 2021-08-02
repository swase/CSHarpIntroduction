using System;
using System.IO;

namespace ExceptionApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            //File Exceptions
            /*
            string pathName = "path\to\file.txt";
            try
            {
                var text = File.ReadAllText(pathName);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File not found!");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error, Exception: {e.Message}");
            }
            */

            try
            {
                Console.WriteLine(Grade(101));
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static string Grade(int mark) 
        {
            if (mark < 0 || mark > 100)
            {
                throw new ArgumentOutOfRangeException($"{mark} out of range. Must be >=0 and <= 100");
            }
            return mark >= 65 ? (mark >= 85 ? "Distinction" : "Pass") : "Fail";
        }
    }
}
