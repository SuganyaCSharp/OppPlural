using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Address
    {
        public Address()
        {

        }
        public Address(int addressid) 
        {
            AddressID = addressid;
        }
        public int AddressID { get; set; }
        public int AddressType { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Streetline1 { get; set; }
        public string Streetline2 { get; set; }
        public bool Validate()
        {
            var Isvalidate = true;
            if (PostalCode == null) Isvalidate = false;
            return Isvalidate;
        }
    }
}
