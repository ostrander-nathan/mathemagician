using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class NaturalNumberTests
    {   // This is a sanity Check Test
        // Ensures everything is hooked up correctly and
        // that the permissions are correct
        [TestMethod]
        public void EnsureICanCreateInstance()
        {
            NaturalNumber naturalNumber = new NaturalNumber();

            Assert.IsNotNull(naturalNumber);
        }

        [TestMethod]
        public void EnsureOneIsTheFirst()
        {
            // Arrange (Where you set stuff up)
            NaturalNumber naturalNumber = new NaturalNumber();

            // Act (Call the method your testing) test 1 method at a time
            int expectedResult = 1;
            int actualResult = naturalNumber.GetFirst();
            // Assert (Check thte output from your method)
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureNextNumber()
        {
            // Arrange (Where you set stuff up)
            NaturalNumber naturalNumber = new NaturalNumber();
            // Act 
            int expectedResult = 2 + 1;
            int actualResult = naturalNumber.GetNext(2);
            // Assert (Check thte output from your method)
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureSequenceIsWorking()
        {
            // Arrange
            NaturalNumber naturalNumber = new NaturalNumber();
            // Act
            int[] expectedResult = new int[] {1,2,3,4,5} ;
            int[] actualResult = naturalNumber.GetSequence(5);
            // Assert (Check thte output from your method)
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsurePrintNumbersIsWorking()
        {
            //Arrange
            NaturalNumber naturalNumber = new NaturalNumber();
            //Act 
            string expectedResult = "1 2 3 4 5";
            // Both below are the same
            //string actualResult = naturalNumber.PrintNumbers(new[] { 1, 2, 3, 4, 5 });
            string actualResult = naturalNumber.PrintNumbers(naturalNumber.GetSequence(5));
            // Assert (Check thte output from your method)
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}
