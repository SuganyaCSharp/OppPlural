using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepsoitory
    {
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);
            if (productId == 2)
            {
                product.ProductName = "sunflower";
                product.ProductDescription = "they are 4 plates for flower";
                product.CurrentPrice=16;
            }
            return product;
        }
        public bool Save(Product product)
        {
            return true;
        }
    }
}
