using System;

namespace MoreMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ConvertPoundsToStones(300));
        }
        public static (int stones, int pounds) ConvertPoundsToStones(int pounds)
        { 
            return (pounds / 14, pounds % 14);
        }
    }
}
