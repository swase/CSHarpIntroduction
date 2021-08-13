using NUnit.Framework;
using SafariParkApp;

namespace SafariParkTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(150, 200, 1)]
        [TestCase(200, 250, 3)]
        [TestCase(200, 200,  4)]
        [TestCase(200, 250, 8)]
        public void GivenCertainSpeedAndMovement_Airplane_ReturnsExpectedPosition(int capacity, int speed, int timesToMove)
        {
            int expectedPosition = (timesToMove * speed);
            var airplane = new Airplane(capacity, speed, "");
            airplane.Move(timesToMove);
            Assert.That(airplane.Position,Is.EqualTo(expectedPosition));
        }

        [TestCase(150, 200, "JetsRUs")]
        [TestCase(200, 250, "Aer Lingus")]
        [TestCase(200, 200, "JetsRUs")]
        [TestCase(200, 250, "Aer Lingus")]
        public void GivenSpeedButNoMovement_Airplane_ReturnsExpectedPosition(int capacity, int speed, string airline)
        {
            int expectedPosition = speed;
            var airplane = new Airplane(capacity, speed, airline);
            airplane.Move();
            Assert.That(airplane.Position, Is.EqualTo(expectedPosition));
        }

        [TestCase(150, 200, "JetsRUs", 1, 100, 500, 0)]
        [TestCase(200, 250, "Aer Lingus", 2, 170, 100, 0)]
        [TestCase(200, 200, "JetsRUs", 10, 500, 1000, 100)]
        [TestCase(200, 250, "Aer Lingus", 200, 350,200,0)]
        public void GivenAllParameters_Airplane_ReturnsExpectedString(int capacity, int speed, string airline, 
            int timesToMove, int numPassengers, int ascend, int descend)
        {
            int altitude = ascend - descend;
            int position = speed * timesToMove;
            var airplane = new Airplane(capacity, speed, airline) { NumPassengers = numPassengers};
            
            airplane.Move(timesToMove);
            airplane.Ascend(ascend);
            airplane.Descend(descend);

            string expectedString = $"Thank you for flying {airline}: " +
                $"SafariParkApp.Airplane capacity: {capacity} passengers: {numPassengers} speed: {speed} " +
                $"position: {position} altitude: {altitude}";
          
            Assert.That(airplane.ToString(), Is.EqualTo(airplane.ToString()));
        }


    }
}