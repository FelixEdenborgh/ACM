﻿using Acme.Common;

namespace ACM.BL
{
    public class Customer : EntityBase, ILoggable
    {

        // constructor
        public Customer() : this(0)
        {
            
        }
        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }


        public List<Address> AddressList { get; set; }
        public int CustomerId { get; private set; } // propg tab tab
        
        public string EmailAddress { get; set; } // prop snippet

        public string FirstName { get; set; }
        public int CustomerType { get; set; }

        // ------------------------------------------------------------------


        public override string ToString() => FullName;
        public string FullName
        {
            get
            {
                string fullName = LastName;
                if(!string.IsNullOrWhiteSpace(FirstName))
                {
                    if(!string.IsNullOrWhiteSpace(FullName)) {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        public static string InstanceCount { get; set; }



        private string _lastName; // denna är låst
        public string LastName // men öppnas här för redigering, eller om jag vill ändrar världet eller läsa ut värdet från den
        {
            get // hämntar property value
            {
                return _lastName;
            }
            set // sätter världet på propertyn
            {
                _lastName = value;
            }
        }


        // Methods
        // ---------------------------------------------------------------------------------------------------

        // Dont need them we have them already now in CustomerRepository class
        //// Retrieve one customer.
        //public Customer Retrieve(int customerId)
        //{
        //    // Code that retrieves the defined customer
        //    return new Customer();
        //}

        //// Retrieve all customers.
        //public List<Customer> Retrieve() 
        //{
        //    // Code that retrieves all of the customers

        //    return new List<Customer>();
        //}

        //// Saves teh current customer.
        //public bool Save()
        //{
        //    // Code that saves the defined customer
        //    return true;
        //}

        // Validates the customer data.
        public override bool Validate()
        {
            var isValid = true;

            if(string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if(string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

        public string Log()
        {
            throw new NotImplementedException();
        }
    }
}
