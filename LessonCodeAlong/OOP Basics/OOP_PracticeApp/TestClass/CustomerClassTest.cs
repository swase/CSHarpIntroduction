using NUnit.Framework;
using OOP_PracticeApp;

namespace TestClass
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("Jane","Doe", "Jane Doe",0)]
        [TestCase("Bilbo", "Baggins", "Bilbo Baggins",1)]
        [TestCase("Arthur", "Pendragon", "Arthur Pendragon",2)]
        [TestCase("Willy", "Wonka", "Willy Wonka", 3)]
        public void InsatntiatingAClass_Customer_GivesExpectedValue(string firstName, string lastName, string expectedFullName, int expectedCustomerID)
        {
           
            Customer customer = new Customer(firstName, lastName);
            Assert.AreEqual(customer.GetFullName(), expectedFullName);
            Assert.AreEqual(customer.CustomerID, expectedCustomerID);
        }
    }
}