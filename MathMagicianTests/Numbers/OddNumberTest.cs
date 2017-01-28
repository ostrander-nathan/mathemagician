using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class OddNumberTest
    {
        [TestMethod]
        public void EnsureICanCreateInstance()
        {
           OddNumber oddNumber = new OddNumber();

            Assert.IsNotNull(oddNumber);
        }

        [TestMethod]
        public void TestIfNumberIsOdd()
        {
            // Arrange
            OddNumber oddNumber = new OddNumber();
            // Act (Call the method your testing)
            int expectedResult = 1;
            int actualResult = oddNumber.GetFirst();
            // Assert (Check thte output from your method)
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestIfEvenGetNext()
        {
            // Arrange
            OddNumber oddNumber = new OddNumber();
            // Act (Call the method your testing)
            int expectedResult = 3;
            int actualResult = oddNumber.GetNext(1);
            // Assert (Check the output from your method)
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureSequenceIsWorking()
        {
            // Arrange
            OddNumber oddNumber = new OddNumber();
            // Act
            int[] expectedResult = new int[] { 1, 3, 5, 7, 9 };
            int[] actualResult = oddNumber.GetSequence(5);
            // Assert (Check thte output from your method)
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }
    }
}
