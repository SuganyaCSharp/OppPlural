using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

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
        [TestMethod]
        public void RetrieveCustomerWithAdress()
        {
            //...Arrange
            var customerRepostory = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailID = "suganya@gamil.com",
                FirstName = "sugu",
                LastName = "sagu",
            };
            List<Address> addresses = new List<Address>();
            var address = new Address(1);
            address.AddressType = 1;
            address.City = "chennai";
            address.Country = "india";
            address.PostalCode = "606603";
            address.State = "tamilnadu";
            address.Streetline1 = "gangai amman koil street";
            address.Streetline2 = "thenamalai";

            var address1 = new Address(2);
            address1.AddressType = 2;
            address1.City = "chennai1";
            address1.Country = "india1";
            address1.PostalCode = "606601";
            address1.State = "tamilnadu1";
            address1.Streetline1 = "gangai amman koil street1";
            address1.Streetline2 = "thenamalai1";

            addresses.Add(address1);
            addresses.Add(address);
            expected.Addresses = addresses;

            //..Act
            var actual = customerRepostory.Retrieve(1);
            //..Assert
            Assert.AreEqual(expected.CustomerID, actual.CustomerID);
            Assert.AreEqual(expected.EmailID, actual.EmailID);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual(expected.Addresses[i].City,actual.Addresses[i].City);
                Assert.AreEqual(expected.Addresses[i].PostalCode,actual.Addresses[i].PostalCode);
                Assert.AreEqual(expected.Addresses[i].Streetline1,actual.Addresses[i].Streetline1);
                Assert.AreEqual(expected.Addresses[i].Streetline2,actual.Addresses[i].Streetline2);
                Assert.AreEqual(expected.Addresses[i].AddressType,actual.Addresses[i].AddressType);
                Assert.AreEqual(expected.Addresses[i].AddressID,actual.Addresses[i].AddressID);
                Assert.AreEqual(expected.Addresses[i].State,actual.Addresses[i].State);

            }
        }
    }
}
