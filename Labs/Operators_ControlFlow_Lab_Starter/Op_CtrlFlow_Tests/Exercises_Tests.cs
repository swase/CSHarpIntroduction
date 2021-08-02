using NUnit.Framework;
using Op_CtrlFlow;
using System.Collections.Generic;
using System;

namespace Op_CtrlFlow_Tests
{
    public class Exercises_Tests
    {     
        // write unit test(s) for MyMethod here
        [TestCase(1,1, false)]
        [TestCase(0, 0, false)]
        [TestCase(24, 24, false)]
        [TestCase(27, 52, false)]
        [TestCase(27, 34, false)]
        [TestCase(20, 60, false)]
        [TestCase(20, 50, false)]
        public void MyMethodTest_returnsFalse(int num1, int num2, bool expectedValue)
        {
            Assert.That(Exercises.MyMethod(num1, num2), Is.EqualTo(expectedValue));
        }

        [Test]
        public void Average_ReturnsCorrectAverage()
        {
            var myList = new List<int>() { 3, 8, 1, 7, 3 };
            Assert.That(Exercises.Average(myList), Is.EqualTo(4.4));
        }

        [Test]
        public void WhenListIsEmpty_Average_ReturnsZero()
        {
            var myList = new List<int>() {};
            Assert.That(() => Exercises.Average(myList),
                Throws.TypeOf<NullReferenceException>().With.Message.Contains("cannot be null"));
        }


        [TestCase(100, "OAP")]
        [TestCase(60, "OAP")]
        [TestCase(59, "Standard")]
        [TestCase(18, "Standard")]
        [TestCase(17, "Student")]
        [TestCase(13, "Student")]
        [TestCase(12, "Child")]
        [TestCase(5, "Child")]
        [TestCase(4, "Free")]
        [TestCase(0, "Free")]
        public void TicketTypeTest(int age, string expected)
        {
            var result = Exercises.TicketType(age);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(-25)]
        [TestCase(-1)]
        [TestCase(101)]
        [TestCase(200)]
        public void  GradeTest_givenAGradeLessThan0OrGreaterThan100_ReturnsArgumentOutOfRange(int grade)
        {
            Assert.That(() => Exercises.Grade(grade),
                Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contains("Mark must be >= 0 and <= 100"));
        }

        [TestCase(75, "Pass with Distinction")]
        [TestCase(76, "Pass with Distinction")]
        [TestCase(90, "Pass with Distinction")]
        [TestCase(99, "Pass with Distinction")]
        [TestCase(100, "Pass with Distinction")]
        public void GradeTest_givenAGradeofGreaterThan75_ReturnsDistinciton(int grade, string expectedValue)
        {
            Assert.That(Exercises.Grade(grade), Is.EqualTo(expectedValue));
        }

        [TestCase(60, "Pass with Merit")]
        [TestCase(61, "Pass with Merit")]
        [TestCase(70, "Pass with Merit")]
        [TestCase(74, "Pass with Merit")]
        public void GradeTest_givenAGradeofGreater59LessThan74_ReturnsMerit(int grade, string expectedValue)
        {
            Assert.That(Exercises.Grade(grade), Is.EqualTo(expectedValue));
        }

        [TestCase(40, "Pass")]
        [TestCase(41, "Pass")]
        [TestCase(55, "Pass")]
        [TestCase(59, "Pass")]
        public void GradeTest_givenAGradeofGreater40LessThan60_ReturnsPass(int grade, string expectedValue)
        {
            Assert.That(Exercises.Grade(grade), Is.EqualTo(expectedValue));
        }

        [TestCase(0, "Fail")]
        [TestCase(1, "Fail")]
        [TestCase(25, "Fail")]
        [TestCase(39, "Fail")]
        public void GradeTest_givenAGradeofLessThan40_ReturnsFail(int grade, string expectedValue)
        {
            Assert.That(Exercises.Grade(grade), Is.EqualTo(expectedValue));
        }

        [TestCase(-10)]
        [TestCase(-1)]
        [TestCase(5)]
        [TestCase(10)]
        public void GetScottishMaxWeddingNumbersTest_GivenLevelLessThan0OrGreaterThan4_ReturnsArugmentOutOfRange(int level)
        {
            Assert.That(() => Exercises.GetScottishMaxWeddingNumbers(level),
                Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contains("must be between 0 and 4 inclusive"));
        }

        [TestCase(0, 200)]
        [TestCase(1, 100)]
        [TestCase(2, 50)]
        [TestCase(3, 50)]
        [TestCase(4, 20)]

        public void GetScottishMaxWeddingNumbersTest_GivenLevel_ReturnsExpectedValue(int level, int expectedValue)
        {
            Assert.That(Exercises.GetScottishMaxWeddingNumbers(level),
                Is.EqualTo(expectedValue));
        }

    }
}
