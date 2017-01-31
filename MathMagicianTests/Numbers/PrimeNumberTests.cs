using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class PrimeNumberTests
    {
        [TestMethod]
        public void EnsureICanCreateInstance()
        {
           PrimeNumber primeNumber = new PrimeNumber();

            Assert.IsNotNull(primeNumber);
        }

        [TestMethod]
        public void TestIfNumberIsPrime()
        {
            // Arrange
            PrimeNumber primeNumber = new PrimeNumber();
            // Act (Call the method your testing)
            int expectedResult = 1;
            int actualResult = primeNumber.GetFirst();
            // Assert (Check thte output from your method)
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestIfPrimeGetNext()
        {
            // Arrange
            PrimeNumber primeNumber = new PrimeNumber();
            // Act (Call the method your testing)
            int expectedResult = 3;
            int actualResult = primeNumber.GetNext(2);
            // Assert (Check the output from your method)
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
