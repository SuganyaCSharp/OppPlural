using ACM.BL;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Acme.CommomTest
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            //Arrange
            var changedItems = new List<ILoggable>();
            var customer = new Customer(1)
            {
                EmailID = "suganya@gmail",
                FirstName="sagu",
                LastName="sugu",
                Addresses=null,
            };
            changedItems.Add(customer);
            var product = new Product(2)
            {
                ProductName="Rake",
                ProductDescription="Garden Rake with steel Head",
                CurrentPrice=6M,
            };
            changedItems.Add(product);
            //Act
            LoggingService.WriteToFile(changedItems);

            //Assert
        }
    }
}
