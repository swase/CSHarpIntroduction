using System;
using System.Collections.Generic;

namespace SafariParkApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hunter and Person class test - inheritance, enacpsulation and abstraction
            /*
            Hunter hunter = new Hunter("James", "Dean", "Cannon") { Age = 32 };
            Hunter hunter2 = new Hunter("Bilbo", "Baggins", "ShireCapture2000") { Age = 111 };
            Hunter hunter3 = hunter;
            Person cait = new Person("Caitlyn", "Jenner", 55);
            //Console.WriteLine($"{hunter.GetFullName()}, of age {hunter.Age}");
            Console.WriteLine($"hunter ToString: {hunter.ToString()}");
            Console.WriteLine($"Person(Cait) to string: {cait.ToString()}");

            Console.WriteLine($"hunter Type: {hunter.GetType()}");
            Console.WriteLine($"hunter1 Equals hunter2: {hunter.Equals(hunter2)}");
            Console.WriteLine($"hunter1 Equals hunter3: {hunter.Equals(hunter3)}");

            hunter.Age = 40;
            Console.WriteLine($"Hunter1 age: {hunter.Age}. Hunter3 age: {hunter3.Age}");
            */

            //Airplane Homework - class test
            /*
            
            Airplane airplane = new Airplane(200, 100, "JetsRUs") { NumPassengers = 150 };
            airplane.Ascend(500);
            Console.WriteLine(airplane.Move(3));
            Console.WriteLine(airplane);
            airplane.Descend(200);
            Console.WriteLine(airplane.Move());
            airplane.Move();
            Console.WriteLine(airplane);
            */

            //Polymorphism, using IMovable interface for objects
            /*
            List<IMovable> gameObjects = new List<IMovable>()
            {
                new Person("Cathy", "French"),
                new Airplane(400,200,"Boeing") {NumPassengers = 100},
                new Vehicle(12, 20) {NumPassengers = 6},
                new Hunter("Henry", "Hodgkins", "Pentax")
            };

            foreach(var element in gameObjects)
            {
                Console.WriteLine(element.Move());
                Console.WriteLine(element.Move(5));
            }
            */

            //Polymorphism Shootout
            /*
            Hunter joeRogan = new Hunter("Joe", "Rogan") {Age = 50 };
            var listOfShooters = new List<IShootable>()
            {
                new Camera("Nikon"),
                new LaserGun("AlderaanDestroyer3000"),
                new WaterPistol("ChildBlaster10000")
                
            };

            foreach (var element in listOfShooters)
            {
                joeRogan.Shooter = element;
                Console.WriteLine(joeRogan.Shoot());
                Console.WriteLine(joeRogan + "\n");
            }
            */

            //Equality and comparison of reference types
            /*
            var bobOne = new Person("Bob", "Builder") { Age = 25 };
            var bobTwo = bobOne;
            var bobThree = new Person("Bob", "Builder") { Age = 25 };

            Console.WriteLine($"Using Equals Comparator: { bobOne == bobThree}");
            Console.WriteLine($"Using Not Equals Comparator: { bobOne != bobThree}");

            Console.WriteLine($"Using Equals Comparator: { bobOne == bobTwo}");
            Console.WriteLine($"Using Not Equals Comparator: { bobOne != bobTwo}");

            var personList = new List<Person>
            {
                new Person("Dawn", "French", 55),
                new Person("Elon", "Musk", 49),
                new Person("Fernando", "Alonso"),
                new Person("Bilbo", "Baggins", 111),
                new Person("Lord", "Sauron", 5500),
            };
            personList.Sort();
            

            foreach(var elem in personList)
            {
                Console.WriteLine(elem);
            }
            */
            //var helen = new Person("Helen", "Troy", 22);
            //var bill = new Hunter("William", "Shakespear") { Age = 467 };

            //Console.WriteLine("List of names");
            //var listOfPeople = new List<Person> { helen, bill};

            //foreach(var elem in listOfPeople)
            //{
            //    Console.WriteLine(elem);
            //}

            var intList = new List<int> { 5, 4, 3, 9, 0 };
            intList.Add(8);
            //Console.WriteLine("List " + intList.ToString());
            intList.Sort();

            //Console.WriteLine("Sorted List: " + intList.ToString());

            intList.RemoveAt(0);
            intList.RemoveAt(0);
            //Console.WriteLine("Removed 2 digits" + intList.ToString());
            intList.Insert(1, 1);
            intList.Reverse();
            //Console.WriteLine("Removed 2 digits" + intList.ToString());


            intList.Remove(9);
            //foreach (var _int in intList) { Console.Write(_int + " "); }

            var personList = new List<Person>
            {
                new Person("Dawn", "French", 55),
                new Person("Elon", "Musk", 49),
                new Person("Fernando", "Alonso"),
                new Person("Bilbo", "Baggins", 111),
                new Person("Lord", "Sauron", 5500),
            };
            //var myQueue = new Queue<Person>();
            //var stack = new Stack<Person>();
            //foreach (var person in personList)
            //{
            //    myQueue.Enqueue(person);
            //}
            //Console.WriteLine("Print Queue\n");
            //foreach(var elem in myQueue)
            //{
            //    Console.WriteLine(elem);
            //}
            //Console.WriteLine("");
            //while (myQueue.Count > 0)
            //{
            //    stack.Push(myQueue.Dequeue());
            //}
            //Console.WriteLine("Print stack \n");
            //foreach (var elem in stack)
            //{
            //    Console.WriteLine(elem);
            //}

            var hashSet = new HashSet<Person>();

            foreach(var elem in personList)
            {
                hashSet.Add(elem);
            }
            Console.WriteLine("\nPrint personList\n");
            foreach(var elem in personList)
            {
                Console.WriteLine(elem);
            }

            Console.WriteLine("\nPrint hashset\n");
            foreach (var elem in hashSet)
            {
                Console.WriteLine(elem);
            }
            Console.WriteLine("\nChange person in personList");
            personList[0].FirstName = "Changed";

            Console.WriteLine("\nPrint personList\n");
            foreach (var elem in personList)
            {
                Console.WriteLine(elem);
            }

            Console.WriteLine("\nPrint hashSet\n");
            foreach (var elem in hashSet)
            {
                Console.WriteLine(elem);
            }

        }
    }
}
