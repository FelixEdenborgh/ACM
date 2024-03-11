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
            // creates the instace of the customer class pass in the requested id
            Customer customer = new Customer(customerId);


            // temporary hard-code values to return a pupulated customer
            if(customerId == 1)
            {
                customer.EmailAddress = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
            }

            return customer;
        }


        // code to save the passed in customer assuming that save proccess where successfull
        public bool Save(Customer customer)
        {
            return true;
        }
    }
}
