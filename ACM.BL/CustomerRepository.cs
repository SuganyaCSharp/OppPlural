using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);
            if (customerId == 1)
            {
                customer.EmailID = "suganya@gamil.com";
                customer.FirstName = "sugu";
                customer.LastName = "sagu";
            }
            return customer;
        }
        public bool Save(Customer customer)
        {
            return true;
        }
    }
}
