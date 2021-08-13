using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace SafariParkApp
{
    public class Person : IMovable, IEquatable<Person>, IComparable<Person>
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}

        public int Age { get; set; }
         
        public Person(string firstName, string lastName, int age = 18)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }  

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public override string ToString()
        {
            //string className = base.ToString().Substring(base.ToString().IndexOf(".") + 1);
            string className = this.GetType().Name;
            return $"Class: {className}  Name: {this.GetFullName()} Age: {Age}";
        }

        public string Move()
        {
            return $"Walking along";
        }

        public string Move(int times)
        {
            return $"Walking along {times} meters";
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Person);
        }

        public bool Equals(Person other)
        {
            return other != null &&
                   this.FirstName == other.FirstName &&
                   this.LastName == other.LastName &&
                   Age == other.Age;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(FirstName, LastName, Age);
        }

        public int CompareTo([AllowNull] Person other)
        {
            if (other == null) return 1;
            if (this.LastName != other.LastName)
            {
                return this.LastName.CompareTo(other.LastName);
            }
            else if (this.FirstName != other.FirstName)
            {
                return this.FirstName.CompareTo(other.FirstName);
            }
            else
            {
                return this.Age.CompareTo(other.Age);
            }
        }

        public static bool operator ==(Person left, Person right)
        {
            return EqualityComparer<Person>.Default.Equals(left, right);
        }

        public static bool operator !=(Person left, Person right)
        {
            return !(left == right);
        }
    }
}