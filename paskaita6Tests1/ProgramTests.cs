using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace paskaitos6_Testai
{
    public class ProgramTests
    {
        [Test]
        public void CalcAddTest()
        {
            // Arrange
            double number1 = 16.5;
            double number2 = 3.5;

            // Act
            double answer = Skaiciuotuvas.CalcAdd(number1, number2);

            // Assert
            Assert.AreEqual(20, answer);
        }

        [Test]
        public void CalcSubtractTest()
        {
            // Arrange
            double number1 = 16.5;
            double number2 = 3.5;

            // Act
            double answer = Program.CalcSubtract(number1, number2);

            // Assert
            Assert.AreEqual(13, answer);
        }

        [Test]
        public void CalcMultiplyTest()
        {
            // Arrange
            double number1 = 4;
            double number2 = 5;

            // Act
            double answer = Program.CalcMultiply(number1, number2);

            // Assert
            Assert.AreEqual(20, answer);
        }

        [Test]
        public void CalcDivideTest()
        {
            // Arrange
            double number1 = 10;
            double number2 = 2;

            // Act
            double answer = Program.CalcDivide(number1, number2);

            // Assert
            Assert.AreEqual(5, answer);
        }

        [Test]
        public void TestDivisionFromZero()
        {
            Assert.Throws<DivideByZeroException>(new TestDelegate(() => DivideByZero()));
        }

        private void DivideByZero()
        {
            // Parse "0" to make sure to get an error at run time, not compile time.
            var a = (1 / Double.Parse("0"));
        }
    }

        [Test]
        public void CalcSqrtTest()
        {
            // Arrange
            double number = 16;

            // Act
            double answer = Program.CalcSqrt(number);

            // Assert
            Assert.AreEqual(4, answer);
        }

        [Test]
        public void CalcSqrtNegativeNumberTest()
        {
            // Arrange
            double number = -16;

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => Program.CalcSqrt(number));
        }

        [Test]
        public void CalcPowTest()
        {
            // Arrange
            double number1 = 2;
            double number2 = 3;

            // Act
            double answer = Program.CalcPow(number1, number2);

            // Assert
            Assert.AreEqual(8, answer);
        }
    }
}
