using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product:EntityBase
    {
        public Product()
        {

        }
        public Product(int productID)
        {
            ProductID = productID;
        }
        public decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        public int ProductID { get; private set; }
        public string ProductName { get; set; }
        public override string ToString()
        {
            return ProductName;
        }
        public override bool Validate()
        {
            bool IsVAlidate = true;
            if (string.IsNullOrWhiteSpace(ProductName)) IsVAlidate=false;
            if (CurrentPrice == null) IsVAlidate = false;
            return IsVAlidate;
        }
    }
}
