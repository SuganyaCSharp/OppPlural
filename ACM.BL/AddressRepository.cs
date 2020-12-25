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
            var address = new Address(addressId);
            address.AddressType = 1;
            address.City = "chennai";
            address.Country = "india";
            address.PostalCode = "606603";
            address.State = "tamilnadu";
            address.Streetline1 = "gangai amman koil street";
            address.Streetline2 = "thenamalai";
            return address;
        }
        public IEnumerable<Address> GetAdrByCustomer(int customerid)
        {
            List<Address> addresses = new List<Address>();
            var address = new Address(1);
            address.AddressType = 1;
            address.City = "chennai";
            address.Country = "india";
            address.PostalCode = "606603";
            address.State = "tamilnadu";
            address.Streetline1 = "gangai amman koil street";
            address.Streetline2 = "thenamalai";

            var address1 = new Address(2);
            address1.AddressType = 2;
            address1.City = "chennai1";
            address1.Country = "india1";
            address1.PostalCode = "606601";
            address1.State = "tamilnadu1";
            address1.Streetline1 = "gangai amman koil street1";
            address1.Streetline2 = "thenamalai1";

            addresses.Add(address1);
            addresses.Add(address);
            return addresses;
        }
        public bool Save(Address address)
        {
            return true;
        }
    }
}
