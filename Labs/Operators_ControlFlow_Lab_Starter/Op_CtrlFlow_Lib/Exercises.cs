using System.Collections.Generic;
using System;

namespace Op_CtrlFlow
{
    public class Exercises
    {
        //Returns false if numbers are the same, else will return true if num2 is a multple of num1
        public static bool MyMethod(int num1, int num2)
        {
            return num1 == num2 ? false : (num1 % num2) == 0;
        }

        // returns the average of the array nums
        public static double Average(List<int> nums)
        {
            if (nums.Count == 0)
            {
                throw new NullReferenceException("List passed cannot be null");
            }
            double sum = 0;
            foreach(int num in nums)
            {
                sum += num;
            }

            return sum / nums.Count;
        }

        // returns the type of ticket a customer is eligible for based on their age
        // "Standard" if they are between 18 and 59 inclusive
        // "OAP" if they are 60 or over
        // "Student" if they are 13-17 inclusive
        // "Child" if they are 5-12
        // "Free" if they are under 5
        public static string TicketType(int age)
        {
            string ticketType = string.Empty;
            if (age < 0)
            {
                throw new ArgumentOutOfRangeException("Cannot have an age < 0");
            }
            else if (age < 5)
            {
                ticketType = "Free";
            }
            else if (age >= 5 && age <= 12)
            {
                ticketType = "Child";
            }

            else if (age > 12 && age < 18)
            {
                ticketType = "Student";
            }

            else if (age >= 18 && age < 60)
            {
                ticketType = "Standard";
            }

            else
            {
                ticketType = "OAP";
            }
            
            return ticketType;
        }

        public static string Grade(int mark)
        {
            string outcome = "";
            if (mark < 0 || mark > 100)
            {
                throw new ArgumentOutOfRangeException("Mark must be >= 0 and <= 100");
            }
            else
            {
                return mark >= 40 ? "Pass" + (mark >= 60 ?  " with " + (mark >= 75 ? "Distinction" : "Merit") : "") : "Fail";
            }

            //else
            //{
            //    if (mark > 40)
            //    {
            //        outcome += "Pass";
            //        if (mark >= 60)
            //        {
            //            outcome += " with ";
            //            if (mark >= 75)
            //            {
            //                outcome += "Distinction";
            //            }
            //            else
            //            {
            //                outcome += "Merit";
            //            }
            //        }
            //    }

            //    else { outcome += "Fail"; }
            //}

            //return outcome;

        }

        public static int GetScottishMaxWeddingNumbers(int covidLevel)
        {
            if (covidLevel < 0 || covidLevel > 4)
            {
                throw new ArgumentOutOfRangeException("Covide levels must be between 0 and 4 inclusive");
            }
            int maxCapacity = 0;
            switch(covidLevel)
            {
                case 0:
                    maxCapacity = 200;
                    break;
                
                case 1:
                    maxCapacity = 100;
                    break;
                
                case 2:
                
                case 3:
                    maxCapacity = 50;
                    break;
                
                case 4:
                    maxCapacity = 20;
                    break;

            }
            return maxCapacity;
        }
    }
}
