using NUnit.Framework;
using FizzBuzzApp;

namespace FizzBuzzTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(7, "7")]
        [TestCase(3,"Fizz")]
        [TestCase(6, "Fizz")]
        [TestCase(9, "Fizz")]
        [TestCase(12, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(10, "Buzz")]
        [TestCase(25, "Buzz")]
        [TestCase(15,"FizzBuzz")]
        [TestCase(30, "FizzBuzz")]
        [TestCase(90, "FizzBuzz")]
        [TestCase(225, "FizzBuzz")]

        public void GivenAnNumber_FizzBuzzReturnsExpectedStringOutput(int num, string expectedOutput)
        {
            Assert.That(Program.FizzBuzz(num), Is.EqualTo(expectedOutput));
        }
    }
}