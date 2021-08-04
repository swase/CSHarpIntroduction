using NUnit.Framework;
using Methods_Lib;
using System;

namespace Methods_Tests
{
    public class TuplesTests
    {
        [TestCase(25, 3, 4)]
        [TestCase(0, 0, 0)]
        [TestCase(33, 4, 5)]
        public void GivenANumber_DaysAndWeeks_ReturnsCorrectTuple(
            int totalDays, int expectedWeeks, int expectedDays)
        {
            var answer = Methods.DaysAndWeeks(totalDays);
            Assert.That(answer.weeks, Is.EqualTo(expectedWeeks), "Weeks");
            Assert.That(answer.days, Is.EqualTo(expectedDays), "Days");
        }
        [Test]
        public void GivenANegativeNumber_DaysAndWeeks_ThrowsAnException()
        {
            Assert.That(() => Methods.DaysAndWeeks(-1), Throws.TypeOf<ArgumentOutOfRangeException>()
        .With.Message.Contain("totalDays must not be negative"));
        }
        [TestCase(0, 0, 0, 0)]
        [TestCase(1, 1, 1, 1)]
        [TestCase(3, 9, 27, 1.7320508)]
        [TestCase(4, 16, 64, 2)]
        [TestCase(3, 9, 27, 1.7320508)]
        [TestCase(100, 10_000, 1_000_000, 10)]
        public void GivenANumber_PowersRoot_ReturnsCorrectTuple(
            int number, int ExpectedSquare, int ExpectedCube, double ExpectedSqrt)
        {
            var answer = Methods.PowersRoot(number);
            Assert.That(answer.square, Is.EqualTo(ExpectedSquare), "Square");
            Assert.That(answer.cube, Is.EqualTo(ExpectedCube), "Cube");
            Assert.That(answer.square_root, Is.EqualTo(ExpectedSqrt).Within(0.0005), "Square Root");
        }
    }
}