using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void Retrievevalid()
        {
            //...Arrange
            var customerRepostory = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailID = "suganya@gamil.com",
                FirstName = "sugu",
                LastName = "sagu",                            
            };
            //..Act
            var actual = customerRepostory.Retrieve(1);
            //..Assert
            Assert.AreEqual(expected.CustomerID, actual.CustomerID);
            Assert.AreEqual(expected.EmailID, actual.EmailID);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
        }
    }
}
