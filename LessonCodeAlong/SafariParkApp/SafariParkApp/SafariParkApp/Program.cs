using System;

namespace SafariParkApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hunter hunter = new Hunter("James", "Dean", "Cannon") { Age = 32};
            //Hunter hunter2 = new Hunter("Bilbo", "Baggins", "ShireCapture2000") { Age = 111 };
            //Hunter hunter3 = hunter;
            //Person cait = new Person("Caitlyn", "Jenner", 55);
            ////Console.WriteLine($"{hunter.GetFullName()}, of age {hunter.Age}");
            //Console.WriteLine($"hunter ToString: {hunter.ToString()}");
            //Console.WriteLine($"Person(Cait) to string: {cait.ToString()}");

            //Console.WriteLine($"hunter Type: {hunter.GetType()}");
            //Console.WriteLine($"hunter1 Equals hunter2: {hunter.Equals(hunter2)}");
            //Console.WriteLine($"hunter1 Equals hunter3: {hunter.Equals(hunter3)}");

            //hunter.Age = 40;
            //Console.WriteLine($"Hunter1 age: {hunter.Age}. Hunter3 age: {hunter3.Age}");

            Airplane airplane = new Airplane(200, 100, "JetsRUs") { NumPassengers = 150 };
            airplane.Ascend(500);
            Console.WriteLine(airplane.Move(3));
            Console.WriteLine(airplane);
            airplane.Descend(200);
            Console.WriteLine(airplane.Move());
            airplane.Move();
            Console.WriteLine(airplane);

        }
    }
}
