using NUnit.Framework;
using TestCalculator;

namespace Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void Additional_WhenCalled_ReturnsSum()
        {
            int a = 5;
            int b = 3;

            var result = _calculator.Additional(a, b);

            Assert.AreEqual(8, result);
        }

        [Test]
        public void Subtraction_WhenCalled_ReturnsDifference()
        {
            int a = 5;
            int b = 3;

            var result = _calculator.Subtraction(a, b);

            Assert.AreEqual(2, result);
        }

        [Test]
        public void Miltiplication_WhenCalled_ReturnsProduct()
        {
            int a = 5;
            int b = 3;

            var result = _calculator.Miltiplication(a, b);

            Assert.AreEqual(15, result);
        }

        [Test]
        public void Division_WhenCalled_ReturnsQuotient()
        {
            int a = 6;
            int b = 3;

            var result = _calculator.Division(a, b);

            Assert.AreEqual(2, result);
        }

        [Test]
        public void Division_WhenDividingByZero_ThrowsDivideByZeroException()
        {
            int a = 6;
            int b = 0;

            Assert.Throws<System.DivideByZeroException>(() => _calculator.Division(a, b));
        }
    }
}
