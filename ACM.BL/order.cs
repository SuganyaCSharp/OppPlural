using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order
    {
        public Order()
        {

        }
        public Order(int orderId)
        {
            OrderID = orderId;
        }
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
