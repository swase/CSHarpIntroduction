using System;
using System.Collections.Generic;
using System.Text;

namespace Collections_Lib
{
    public class CollectionsExercises
    {

        /* removes and returns the next num entries in the queue, as a comma separated string */
        public static string NextInQueue(int num, Queue<string> queue)
        {
            int count = queue.Count;
            var result = new StringBuilder("");
            for (int i = 1; i <= num; i++)
            {
                if(i <= count)
                {
                    result.Append(queue.Dequeue() + ", ");
                }
                
            }
           
            return result.ToString().Trim().Trim(',');


        }

        /* uses a Stack to create and return array of ints in reverse order to the one supplied */
        public static int[] Reverse(int[] original)
        {
            var stack = new Stack<int>();
            int[] reversedArr = new int[original.Length];

            if (original.Length == 0)
            {
                return reversedArr;
            }
            
            foreach(var _int in original)
            {
                stack.Push(_int);
            }

            for (int i = 0; i < reversedArr.Length; i++)
            {
                reversedArr[i] = stack.Pop();
            }
            return reversedArr;
        
        }
        // using a Dictionary, counts and returns (as a string) the occurence of the digits 0-9 in the given string
        public static string CountDigits(string input)
        {
            var result = new StringBuilder("");
            var dictionaryCount = new Dictionary<char, int>();
            
            if (input.Equals(""))
            {
                return "";
            }

            foreach(char ch in input)
            {
                if (Char.IsDigit(ch))
                {
                    if (dictionaryCount.ContainsKey(ch))
                    {
                        dictionaryCount[ch]++;
                    }
                    else
                    {
                        dictionaryCount.Add(ch,1);
                    }
                }
            }

            foreach(var item in dictionaryCount)
            {
                result.Append($"[{item.Key}, {item.Value}]");
            }
            return result.ToString();
        }
    }
}
