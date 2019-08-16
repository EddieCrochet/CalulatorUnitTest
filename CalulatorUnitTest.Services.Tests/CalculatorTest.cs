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

        }
    }
}
