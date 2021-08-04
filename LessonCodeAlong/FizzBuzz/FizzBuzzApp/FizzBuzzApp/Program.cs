using System;
using System.Text;

namespace FizzBuzzApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static string FizzBuzz(int num)
        {
            var result = new StringBuilder("");


            if (num % 3 != 0 && num % 5 != 0)
            {
                result.Append(num);
            }
            else
            {
                if (num % 3 == 0)
                {
                    result.Append("Fizz");
                }

                if (num % 5 == 0)
                {
                    result.Append("Buzz");
                }

            }


            return result.ToString();
        }

        public static bool DivisibleBy(int num1, int num2)
        {
            bool result;
            if (num2 > 0)
            {
                result = (num1 % num2) == 0;
            }
            else { result = false; }
            return result;
        }
    }
}
