using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {

        }
        public OrderItem(int orderItemid)
        {
            OrderItemID = orderItemid;
        }
        public int OrderItemID { get; private set; }
        public int ProductID { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }
        public OrderItem Retrieve(int orderId)
        {
            return new OrderItem();
        }
        public bool save()
        {
            return true;
        }
        public bool Validate()
        {
            bool IsVAlidate = true;
            if (ProductID <= 0) IsVAlidate = false;
            if (Quantity <= 0) IsVAlidate = false;
            if (PurchasePrice == null) IsVAlidate = false;
            return IsVAlidate;
        }
    }
}
