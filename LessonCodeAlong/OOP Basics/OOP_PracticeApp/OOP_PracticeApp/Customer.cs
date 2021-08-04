using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PracticeApp
{
    public class Customer
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        private static int _customerCount = 0; 

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
        public int CustomerID { get; init; } = _customerCount;

        public Customer()
        {
            _customerCount++;

        }
        public Customer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            _customerCount++;

        }
    }
}
