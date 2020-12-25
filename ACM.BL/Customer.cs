﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        public Customer()
        {

        }
        public Customer(int customerId)
        {
            CustomerID = customerId;
        }
        public static int InstanceCount { get; set; }
        public int CustomerID { get; private set; }
        public string EmailID { get; set; }
        public string FirstName { get; set; }
        public string  FullName { 
            get 
            {
                string fullname = LastName;
                if (!string.IsNullOrEmpty(FirstName))
                {
                    if (!string.IsNullOrEmpty(fullname))
                    {
                        fullname += ", ";
                    }
                    fullname += FirstName;
                }
                return fullname;
            }
        }
        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public bool Validate()
        {
            bool IsVAlidate = true;
            if (string.IsNullOrWhiteSpace(LastName)) IsVAlidate=false;
            if (string.IsNullOrWhiteSpace(EmailID)) IsVAlidate = false;
            return IsVAlidate;
        }
    }
}