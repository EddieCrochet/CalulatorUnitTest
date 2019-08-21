using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalulatorUnitTest.Services.Tests
{
    [TestClass]
    public class CalculatorTest
    {
        Calculator _calc;

        public CalculatorTest()
        {
            _calc = new Calculator();
        }

        //method to make sure add function in calculator class works
        [TestMethod]
        public void ShouldAddTwoNumbers()
        {
            int res = _calc.Add(5, 3);
            Assert.AreEqual(res, 8);
        }

        //method to ensure the Sub function in the calculator class works
        [TestMethod]
        public void SouldSubtracttwoNumbers()
        {
            int res = _calc.Sub(5, 3);
            Assert.AreEqual(res, 2);
        }

        [TestMethod]
        public void PressEquals_TwoPlusTwo_ReturnsFour()
        {
            // Arrange
            decimal value1 = 2m;
            decimal value2 = 2m;
            decimal expected = 4m;
            var calculator = new Calculator();

            // Act
            calculator.Enter(value1);
            calculator.PressPlus();
            calculator.Enter(value2);
            calculator.PressEquals();
            decimal actual = calculator.Display;

            // Assert
            Assert.AreEqual(expected, actual,
                            "When adding {0} + {1}, expected {2} but found {3}.", value1, value2, expected, actual);
        }
    }
}
