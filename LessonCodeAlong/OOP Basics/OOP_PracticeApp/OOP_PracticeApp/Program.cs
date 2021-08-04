using System;

namespace OOP_PracticeApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer jean = new Customer("Jean", "Gray");
            Console.WriteLine(jean.GetFullName() + $"CustomerID: {jean.CustomerID}");

            Customer billie = new Customer("Billie", "Bob");
            Console.WriteLine(billie.GetFullName() + $", CustomerID: {billie.CustomerID}");
        }

        public struct Point3D
        {
            public int x;
            public int y, z;
            public Point3D(int x, int y, int z = 5)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }
        }
    }
}
