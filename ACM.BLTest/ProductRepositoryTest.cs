using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //..Arrange
            var productRepository = new ProductRepsoitory();
            var expected = new Product(2)
            {
                CurrentPrice = 16,
                ProductDescription = "they are 4 plates for flower",
                ProductName = "sunflower",
            };
            //..Act
            var actual = productRepository.Retrieve(2);
            //..Assert
            Assert.AreEqual(expected.ProductID,actual.ProductID);
            Assert.AreEqual(expected.ProductName,actual.ProductName);
            Assert.AreEqual(expected.ProductDescription,actual.ProductDescription);
            Assert.AreEqual(expected.CurrentPrice,actual.CurrentPrice);
        }
    }
}
