using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {
        public OrderRepository()
        {
            orderItemRepository = new OrderItemRepository();
        }
        private OrderItemRepository orderItemRepository { get; set; }
        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);
            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
                order.Customerid = 1;
                order.ShippingAddressid = 12;
                order.OrderItems = orderItemRepository.GetOrderItems(orderId).ToList();
            }
            return order;
        }

        public bool Save(Order order)
        {
            var success = true;
            if (order.Haschanges)
            {
                if (order.Isvalid)
                {
                    if (order.IsNew)
                    {

                    }
                    else
                    {

                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
    }
}
