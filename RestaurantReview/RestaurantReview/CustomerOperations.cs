using System;
using System.Collections.Generic;

namespace RestaurantReview
{
    class CustomerOperations
    {
        List<CustomerDetails> CustomerList = new List<CustomerDetails>();
        public void AddCustomers(CustomerDetails customer)
        {
            CustomerList.Add(customer);
            Console.WriteLine("Customer list has been updated");
        }
        public void DeleteCustomer(string name)
        {
            CustomerDetails value = null;
            foreach (CustomerDetails customer in CustomerList)
            {

                if (customer.name.Contains(name))
                {
                    Console.WriteLine("True");
                    value = customer;
                   
                }
                
            }
            if (value != null)
            {
                CustomerList.Remove(value);
            }

        }
        public void Display()
        {
            foreach (CustomerDetails customer in CustomerList)
                customer.Display();
        }

    }
}
