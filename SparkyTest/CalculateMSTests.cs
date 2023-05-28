using Sparky;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkyTest
{
    [TestClass]
    public class CalculateMSTests
    {
        [TestMethod]
        public void AddNumbers_InputTwoInt_GetCorrectAddition()
        {
            //Arrange
            Calculator cal = new();
            //Act
            int result = cal.AddNumbers(10, 20);
            //Assert
            Assert.AreEqual(30, result);
        }
       
    }
}
