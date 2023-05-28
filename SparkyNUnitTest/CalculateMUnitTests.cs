using NUnit.Framework;
using Sparky;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkyNUnitTest
{
    [TestFixture]
    public class CalculateMUnitTests
    {
        [Test]
        public void AddNumbers_InputTwoInt_GetCorrectAddition()
        {
            //Arrange
            Calculator cal = new();
            //Act
            int result = cal.AddNumbers(10, 20);
            //Assert
            Assert.AreEqual(30, result);
        }
        [Test]
        public void IsOddChecker_InputEvenNumber_ReturnFalse()
        {
            Calculator cal = new();
            bool isOdd = cal.IsOddNumber(10);
            Assert.That(isOdd, Is.EqualTo(false));
            Assert.IsFalse(isOdd);
        }
        [Test]
        [TestCase(11)]
        [TestCase(13)]
        public void IsOddChecker_InputEvenNumber_ReturnTrue(int a)
        {
            Calculator cal = new();
            bool isOdd = cal.IsOddNumber(a);
            Assert.That(isOdd, Is.EqualTo(true));
            Assert.IsTrue(isOdd);
        }

        [TestCase(11,ExpectedResult =true)]
        [TestCase(12,ExpectedResult =false)]
        public bool IsOddChecker_InputEvenNumber_ReturnTrueIfOdd(int a)
        {
            Calculator cal = new();
            return cal.IsOddNumber(a);
        }

        [Test]
        [TestCase(5.4,10.5)] // 15.9
        [TestCase(5.43, 10.53)] //15.93
        [TestCase(5.49, 10.59)] // 16.08
        public void AddNumbers_InputTwoSouble_GetCorrectAddition(double a, double b)
        {
            //Arrange
            Calculator cal = new();
            //Act
            double result = cal.AddNumbersDouble(a, b);
            //Assert
            Assert.AreEqual(15.9, result,.1);
        }
    }
}
