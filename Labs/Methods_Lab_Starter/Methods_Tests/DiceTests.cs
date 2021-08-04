using NUnit.Framework;
using System;
using Methods_Lib;
using System.Threading.Tasks;



namespace Methods_Tests
{
    public class DiceTests
    {
        [Test]
        public void RollDice_ReturnsValueBetween1And12Inclusive()
        {
            for (int i = 0; i < 1000; i++)
            {
                var rand = new Random();
                Assert.That(Methods.RollDice(rand),Is.LessThan(13));
                Assert.That(Methods.RollDice(rand), Is.GreaterThan(1));
                Task.Delay(100);
            }
            
        }

        [Test]
        public void GivenACertainSeed_RollDice_ReturnsSameNumber()
        {
            var rand_arg = new Random(10);
            var rand_test = new Random(10);
            var expectedRandValue = rand_test.Next(1, 7) + rand_test.Next(1,7);
            Assert.That(Methods.RollDice(rand_arg), Is.EqualTo(expectedRandValue));
        }
    }
}
