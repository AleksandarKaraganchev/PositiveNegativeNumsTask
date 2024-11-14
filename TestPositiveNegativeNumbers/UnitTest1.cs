using PositiveNegativeNums;

namespace TestPositiveNegativeNumbers
{
    public class Tests
    {
        [TestFixture]
        public class PositiveNegativeNumbersTests
        {
            [TestCase(1)]
            [TestCase(2)]
            [TestCase(55000)]
            public void TestIfPositiveNumbersReturnsTrue(double positiveNumber)
            {
                // Arrange
                PositiveNegativeNum positiveNegativeNumbers = new PositiveNegativeNum();

                // Act
                bool result = positiveNegativeNumbers.IsPositive(positiveNumber);

                // Assert
                Assert.IsTrue(result, "Chisloto e pozitivno");
            }

            [TestCase(-1)]
            [TestCase(-12321)]
            [TestCase(-1232321)]
            [TestCase(-1112)]
            public void TestIfNegativeNumbersReturnFalse(double negativeNumber)
            {
                // Arrange
                PositiveNegativeNum positiveNegativeNumbers = new PositiveNegativeNum();
                // Act
                bool result = positiveNegativeNumbers.IsPositive(negativeNumber);
                // Assert
                Assert.IsFalse(result, "Chisloto e otricatelno");
            }

            [Test]
            public void TestIf0InputReturnsArgumentException()
            {
                // Arrange
                PositiveNegativeNum positiveNegativeNumbers = new PositiveNegativeNum();
                double zero = 0;
                //Assert
                Assert.ThrowsException<ArgumentException>(() => positiveNegativeNumbers.IsPositive(zero));
            }
        }
    }
}