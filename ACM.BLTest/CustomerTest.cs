using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest   
    {
        [TestMethod]
        public void FullNameValidTest()
        {
            //Arrange
            Customer customer = new Customer();
            customer.FirstName = "baby";
            customer.LastName = "sugu";
            string expected = "sugu, baby";
            //Act
            string actual = customer.FullName;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FullNameValidEmpty()
        {
            //Arrange
            Customer customer = new Customer();
            customer.LastName = "sugu";
            string expected = "sugu";
            //Act
            string actual = customer.FullName;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void staticTest()
        {
            //Arrange
            Customer customer = new Customer();
            customer.LastName = "sugu";
            //customer.InstanceCount += 1;
            Customer customer1 = new Customer();
            customer.LastName = "venkat";
            //Customer.InstanceCount += 1;
            int expected = 2;
            //Assert
            //Assert.AreEqual(expected,Customer.InstanceCount);
        }
        [TestMethod]
        public void ValidateValid()
        {
            //Arrange
            Customer customer = new Customer();
            customer.LastName = "sugu";
            customer.EmailID = "suganya@gmail";
            //Act
            var expected = true;
            var actual = customer.Validate();
            //Assert
            Assert.AreEqual(expected,actual);
        }
    }
}
