using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderItemRepository
    {
        public OrderItem Retrieve(int orderId)
        {
            OrderItem orderitem = new OrderItem(orderId);
            orderitem.ProductID = 1;
            orderitem.PurchasePrice = 120;
            orderitem.Quantity = 15;
            return orderitem;
        }
        public List<OrderItem> GetOrderItems(int orderid)
        {
            List<OrderItem> orderItems = new List<OrderItem>();
            OrderItem orderitem = new OrderItem(1);
            orderitem.ProductID = 1;
            orderitem.PurchasePrice = 120;
            orderitem.Quantity = 15;
            orderItems.Add(orderitem);
            return orderItems;
        }
        public bool save()
        {
            return true;
        }
    }
}
