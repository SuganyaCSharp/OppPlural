using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            var address = new Address();
            address.AddressID = addressId;
            address.AddressType = 1;
            address.City = "chennai";
            address.Country = "india";
            return address;
        }
        public bool Save(Address address)
        {
            return true;
        }
    }
}
