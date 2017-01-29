using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class EvenNumberTests
    {
        [TestMethod]
        public void EnsureICanCreateInstance()
        {
            EvenNumber evenNumber = new EvenNumber();
            Assert.IsNotNull(evenNumber);
        }

        [TestMethod]
        public void TestIfNumberIsEven()
        {
            // Arrange
            EvenNumber evenNumber = new EvenNumber();
            // Act (Call the method your testing)
            int expectedResult = 2;
            int actualResult = evenNumber.GetFirst();
            // Assert (Check thte output from your method)
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestIfEvenGetNext()
        {
            // Arrange
            EvenNumber evenNumber = new EvenNumber();
            // Act (Call the method your testing)
            int expectedResult = 4;
            int actualResult = evenNumber.GetNext(2);
            // Assert (Check the output from your method)
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureSequenceIsWorking()
        {
            // Arrange
            EvenNumber evenNumber = new EvenNumber();
            // Act
            int[] expectedResult = new int[] { 2, 4, 6, 8, 10 };
            int[] actualResult = evenNumber.GetSequence(5);
            // Assert (Check thte output from your method)
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanPrintSequence()
        {
            // Arrange
            EvenNumber EvenNumber = new EvenNumber();
            // Act
            string expectedResult = "2 4 6 8 10";
            int[] inputArray = new[] { 2, 4, 6, 8, 10 };
            string actualResult = EvenNumber.PrintNumbers(inputArray);
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
