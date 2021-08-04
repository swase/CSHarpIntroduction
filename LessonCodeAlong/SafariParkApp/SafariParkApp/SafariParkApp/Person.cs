using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SafariParkApp
{
    public class Person
    {
        private string _firstName;
        private string _lastName;

        public int Age { get; set; }
         
        public Person(string firstName, string lastName, int age = 18)
        {
            _firstName = firstName;
            _lastName = lastName;
            Age = age;
        }  

        public string GetFullName()
        {
            return $"{_firstName} {_lastName}";
        }

        public override string ToString()
        {
            string _class = base.ToString().Substring(base.ToString().IndexOf(".") + 1);
            return $"Class: {_class}  Name: {this.GetFullName()} Age: {Age}";
        }
    }
}