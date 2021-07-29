using NUnit.Framework;
using ExceptionDataTypeTests;
using ExceptionApp;
using System;

namespace ExceptionDataTypeTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(-1)]
        [TestCase(-23)]
        public void GivenAGradeLessThan0_Grade_ReturnsArgumentOutOfRangeException(int mark)
        {
            Assert.That(()=> Program.Grade(mark), 
                Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contains("Must be >=0 and <= 100"));
        }

        [TestCase(101)]
        [TestCase(200)]
        public void GivenAGradeGreaterThan100_Grade_ReturnsArgumentOutOfRangeException(int mark)
        {
            Assert.That(() => Program.Grade(mark), 
                Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contains("Must be >=0 and <= 100"));
        }
    }
}