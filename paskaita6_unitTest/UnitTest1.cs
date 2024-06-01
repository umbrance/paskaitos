using paskaita6;
namespace paskaita6_unitTest
{
    public class Tests
    {
        [Test]
        public void SumReturnsSum()
        {
            // Arange

            int number = 4;
            int number2 = 6;

            // Act
            //int answer = Program.Sum(number, number2);

            // Assert

            Assert.AreEqual(10, answer);
        }
        [Test]

        public void MultiplyAndAddOne_IsOneAdded()
        {
            // Arrange

            int number = 7;
            int number2 = 7;

            // Act

            //int answer = Program.MultiplyAndAddOne(number, number2, true);

            // Assert

            Assert.AreEqual(50, answer);
        }

    }
}