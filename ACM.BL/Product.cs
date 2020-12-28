using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product:EntityBase, ILoggable
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
        private string _ProductName;
        public string ProductName 
        {
            get 
            {
                return _ProductName.InsertSpaces();
            }
            set
            {
                _ProductName = value;
            } 
        }
        public string Log() =>
            $"{ProductID}: {ProductName} Detail: {ProductDescription} status: {EntityState.ToString()}";
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
