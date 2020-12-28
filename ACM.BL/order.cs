using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order:EntityBase, ILoggable
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

        public string Log() =>
            $"{OrderID} Date: {this.OrderDate.Value.DateTime} Status: {this.EntityState.ToString()}";
        public override string ToString()
        {
            return $"{OrderDate.Value.Date} ({OrderID})";
        }
        public override bool Validate()
        {
            bool IsVAlidate = true;
            if (OrderDate == null) IsVAlidate = false;
            return IsVAlidate;
        }
    }
}
