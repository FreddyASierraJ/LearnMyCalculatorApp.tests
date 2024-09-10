using Microsoft.VisualStudio.TestTools.UnitTesting;
using LearnMyCalculatorApp;

namespace LearnMyCalculatorApp.tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculatorNullTest()
        {
            var calculator = new Calculator();
            Assert.IsNull(calculator);
            Assert.IsTrue(false);
        }
    }
}