using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class FibonacciNumberTests
    {
        [TestMethod]
        public void EnsureICanCreateInstance()
        {
            FibonacciNumber fibonacciNumber = new FibonacciNumber();
            Assert.IsNotNull(fibonacciNumber);
        }

        [TestMethod]
        public void TestIfNumberIsFibonacci()
        {
            // Arrange
            FibonacciNumber fibonacciNumber = new FibonacciNumber();
            // Act (Call the method your testing)
            int expectedResult = 1;
            int actualResult = fibonacciNumber.GetFirst();
            // Assert (Check thte output from your method)
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestIfFibonacciGetNext()
        {
            // Arrange
            FibonacciNumber fibonacciNumber = new FibonacciNumber();
            // Act (Call the method your testing)
            int expectedResult = 5;
            int actualResult = fibonacciNumber.GetNextFib(2,3);
            // Assert (Check the output from your method)
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureSequenceIsWorking()
        {
            // Arrange
            FibonacciNumber fibonacciNumber = new FibonacciNumber();
            // Act
            int[] expectedResult = new int[] { 1, 1, 2, 3, 5 };
            int[] actualResult = fibonacciNumber.GetSequence(5);
            // Assert (Check thte output from your method)
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanPrintSequence()
        {
            // Arrange
            FibonacciNumber fibonacciNumber = new FibonacciNumber();
            // Act
            string expectedResult = "1 1 2 3 5";
            int[] inputArray = new[] { 1, 1, 2, 3, 5 };
            string actualResult = fibonacciNumber.PrintNumbers(inputArray);
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
