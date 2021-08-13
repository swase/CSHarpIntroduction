using System;
using System.Collections.Generic;
namespace MoneyCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter money:");
            double money = Convert.ToDouble(Console.ReadLine());
            int[] typeOfChange = new int[12];
            string[] nameOfChange = new string[]
            {
                "£50","£20","£10","£5","£2","£1","50p","20p","10p", "5p", "2p", "1p"
            };
            while (money >= 0.01)
            {
                if (money - 50 >= 0)
                {
                    money -= 50;
                    typeOfChange[0]++;
                }
                else if (money - 20 >= 0)
                {
                    money -= 20;
                    typeOfChange[1]++;
                }
                else if (money - 10 >= 0)
                {
                    money -= 10;
                    typeOfChange[2]++;
                }
                else if (money - 5 >= 0)
                {
                    money -= 5;
                    typeOfChange[3]++;
                }
                else if (money - 2 >= 0)
                {
                    money -= 2;
                    typeOfChange[4]++;
                }
                else if (money - 1 >= 0)
                {
                    money -= 1;
                    typeOfChange[5]++;
                }
                else if (money - 0.5 >= 0)
                {
                    money -= 0.5;
                    typeOfChange[6]++;
                }
                else if (money - 0.2 >= 0)
                {
                    money -= 0.2;
                    typeOfChange[7]++;
                }
                else if (money - 0.1 >= 0)
                {
                    money -= 0.1;
                    typeOfChange[8]++;
                }
                else if (money - 0.05 >= 0)
                {
                    money -= 0.05;
                    typeOfChange[9]++;
                }
                else if (money - 0.02 >= 0)
                {
                    money -= 0.02;
                    typeOfChange[10]++;
                }
                else if (money - 0.01 >= 0)
                {
                    money -= 0.01;
                    typeOfChange[11]++;
                }
            }
            for (int i = 0; i < typeOfChange.Length; i++)
            {
                Console.WriteLine($"{nameOfChange[i]}: {typeOfChange[i]}");
            }
            Console.WriteLine("Enter number to convert to Roman numerals");
            int num = Convert.ToInt32(Console.ReadLine());
            while (num > 0)
            {
                if (num >= 1000)
                {
                    num -= 1000;
                    Console.Write("M");
                }
                else if (num >= 500)
                {
                    num -= 500;
                    Console.Write("D");
                }
                else if(num >= 100)
                {
                    num -= 100;
                    Console.Write("C");
                }
                else if (num >= 50)
                {
                    num -= 50;
                    Console.Write("L");
                }
                else if (num >= 20)
                {
                    num -= 20;
                    Console.Write("XX");
                }
                else if (num >= 19)
                {
                    num -= 19;
                    Console.Write("XIX");
                }
                else if (num >= 18)
                {
                    num -= 18;
                    Console.Write("XVIII");
                }
                else if (num >= 17)
                {
                    num -= 17;
                    Console.Write("XVII");
                }
                else if (num >= 16)
                {
                    num -= 16;
                    Console.Write("XVI");
                }
                else if (num >= 15)
                {
                    num -= 15;
                    Console.Write("XV");
                }
                else if (num >= 14)
                {
                    num -= 14;
                    Console.Write("XIV");
                }
                else if (num >= 13)
                {
                    num -= 13;
                    Console.Write("XIII");
                }
                else if (num >= 12)
                {
                    num -= 12;
                    Console.Write("XII");
                }
                else if (num >= 11)
                {
                    num -= 11;
                    Console.Write("XI");
                }
                else if (num >= 10)
                {
                    num -= 10;
                    Console.Write("X");
                }
                else if (num >= 9)
                {
                    num -= 18;
                    Console.Write("IX");
                }
                else if (num >= 8)
                {
                    num -= 8;
                    Console.Write("VIII");
                }
                else if (num >= 7)
                {
                    num -= 7;
                    Console.Write("VII");
                }
                else if (num >= 6)
                {
                    num -= 6;
                    Console.Write("VI");
                }
                else if (num >= 5)
                {
                    num -= 5;
                    Console.Write("V");
                }
                else if (num >= 4)
                {
                    num -= 4;
                    Console.Write("IV");
                }
                else if (num >= 3)
                {
                    num -= 3;
                    Console.Write("III");
                }
                else if (num >= 2)
                {
                    num -= 2;
                    Console.Write("II");
                }
                else if (num >= 1)
                {
                    num -= 1;
                    Console.Write("I");
                }
            }

        }
    }
}
