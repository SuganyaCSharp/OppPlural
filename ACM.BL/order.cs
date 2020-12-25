using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order
    {
        public Order() : this(0)
        {

        }
        public Order(int orderId)
        {
            OrderID = orderId;
            OrderItems = new List<OrderItem>();
        }
        public int Customerid { get; set; }
        public int ShippingAddressid { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public int OrderID { get; private set; }
        public DateTimeOffset? OrderDate { get; set; }
        
        public bool Validate()
        {
            bool IsVAlidate = true;
            if (OrderDate == null) IsVAlidate = false;
            return IsVAlidate;
        }
    }
}
