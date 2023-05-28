using NUnit.Framework;
using Sparky;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkyNUnitTest
{
    [TestFixture]
    public class CustomerNUnitTests
    {
        [Test]
        public void CombineName_InputFirstAndLastName_ReturnFullName()
        {
            //Arrange
            var customer = new Customer();
            //Act
            string fullName = customer.CombineName("Ben", "Spark");
            //Assert
            Assert.That(fullName, Is.EqualTo("Hello, Ben Spark"));
            Assert.AreEqual(fullName, "Hello, Ben Spark");
            Assert.That(fullName, Does.Contain("ben Spark").IgnoreCase);
            Assert.That(fullName, Does.StartWith("Hello,"));
            Assert.That(fullName, Does.EndWith("Spark"));
        }
    }
}
