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
        [TestMethod]
        public void AddTest() 
        {
            // Arrange
            var calculator = new Calculator();
            
            //Act
            var actual = calculator.Add(1, 1);
            
            //Assert
            Assert.AreEqual(2, actual);
        }
        [TestMethod]
        public void SubtractTest()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var actual= calculator.Subtract(3, 1);

            //Assert
            Assert.AreEqual(2, actual);
        }
        [TestMethod]
        public void MultiplyTest() 
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var actual =calculator.Multiply(3, 1);

            //Assert
            Assert.AreEqual(3, actual);
        }
        [TestMethod]
        public void DivideTest() 
        {
            var calculator = new Calculator();

            var actual=calculator.Divide(3, 0);

            Assert.ThrowsException<InvalidOperationException>(() => actual);
        }

    }
}