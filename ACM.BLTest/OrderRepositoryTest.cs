using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ACM.BLTest
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void ReterieveValid()
        {
            //..Arrange
            var orderRepository = new OrderRepository();
            List<OrderItem> orderItems = new List<OrderItem>();
            OrderItem orderitem = new OrderItem(1);
            orderitem.ProductID = 1;
            orderitem.PurchasePrice = 120;
            orderitem.Quantity = 15;
            orderItems.Add(orderitem);
            var expected = new Order(10)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0)),
                Customerid = 1,
                ShippingAddressid = 12,
                OrderItems = orderItems,
            };
            //..Act
            var actual = orderRepository.Retrieve(10);
            //..Assert
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
            Assert.AreEqual(expected.Customerid, actual.Customerid);
            Assert.AreEqual(expected.ShippingAddressid, actual.ShippingAddressid);
            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.OrderItems[i].ProductID, actual.OrderItems[i].ProductID);
                Assert.AreEqual(expected.OrderItems[i].PurchasePrice, actual.OrderItems[i].PurchasePrice);
                Assert.AreEqual(expected.OrderItems[i].Quantity, actual.OrderItems[i].Quantity);
                Assert.AreEqual(expected.OrderItems[i].OrderItemID, actual.OrderItems[i].OrderItemID);
            }
        }
    }
}
