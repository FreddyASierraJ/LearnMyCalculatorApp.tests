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
            //Arrange
            var calculator = new Calculator();
            
            //Act
            Assert.IsNull(calculator);

            //Assert
            Assert.IsNotNull(false);
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
            var actual =calculator.Multiply(1, 1);

            //Assert
            Assert.AreEqual(1, actual);
        }
        [TestMethod]
        public void DivideTest() 
        {
            var calculator = new Calculator();

            var actual=calculator.Divide(4, 2);

            Assert.AreEqual(2, actual);
        }
        [TestMethod]
        public void DivideByZeroTest() 
        {
            var calculator = new Calculator();

            var actual = calculator.DivideByZero(1, 0);

            Assert.IsTrue(actual == null);
        }

    }
}