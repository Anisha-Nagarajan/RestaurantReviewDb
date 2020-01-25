using System;
using System.Text.RegularExpressions;

namespace RestaurantReview
{
    class Validation
    {
        public string name;
        public string email;
        public string location;
        public string phoneNumber;
        public string restaurantName;
        public string comment;
        public byte rating;

        public void GetName()
        {

            Console.WriteLine("Enter your name");
            name = Console.ReadLine();
            if (!Regex.Match(name, "^[A-Z][a-zA-Z]*$").Success)
            {
                Console.WriteLine("Invalid name");
                GetName();
            }


        }
        public void GetEmail()
        {
            Console.WriteLine("Enter your email");
            email = Console.ReadLine();
           
             if (!Regex.Match(email,@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*").Success)
            {
                Console.WriteLine("Invalid Email");
                GetEmail();
            }
        }
        public void GetLocation()
        {
            Console.WriteLine("Enter your location");
            location = Console.ReadLine();
            if (!Regex.Match(location, "^[A-Z][a-zA-Z]*$").Success)
            {
                Console.WriteLine("Invalid name");
                GetLocation();
            }

        }
        public void GetPhoneNumber()
        {
            Console.WriteLine("Enter your phone number");
            phoneNumber = Console.ReadLine();
            if (!Regex.Match(phoneNumber, "^[3-9][0-9]{9}$").Success)
            {
                Console.WriteLine("Invalid phoneNumber");
                GetPhoneNumber();
            }
               
        }
        public void GetRestaurantName()
        {
            Console.WriteLine("Enter restaurant Name");
            restaurantName = Console.ReadLine();
            foreach (RestaurantDetails restaurant in AdminOperations.restaurantList)
            {
                if (restaurant.restaurantName.Contains(restaurantName))
                {
                    Console.WriteLine("True");
                    restaurant.Display();
                }
                else
                {
                    Console.WriteLine("The restaurant does not exist");
                }
            }

        }
        public void GetComment()
        {
            Console.WriteLine("Enter your Comment");
            comment = Console.ReadLine();
        }
        public void GetRating()
        {
            Console.WriteLine("Enter your Rating from 1 to 5");
            rating = Convert.ToByte(Console.ReadLine());
     

        }
        public void GetId()
        {
            int id = 0003;
            id = id + 1;
            CustomerDetails customer = new CustomerDetails(name, email, location, phoneNumber,restaurantName, comment, rating,id);
            CustomerOperations operation = new CustomerOperations();
            operation.AddCustomers(customer);
        }

    }
}
