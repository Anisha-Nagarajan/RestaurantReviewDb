using System;


namespace RestaurantReview
{
    class CustomerDetails
    {
        public string name { get; set; }
        public string email { get; set; }
        public string location { get; set; }
        public string phoneNumber { get; set; }
        public string restaurantName { get; set; }
        public string comment { get; set; }
        public byte rating { get; set; }
        public int id { get; set; }
        
        public CustomerDetails(string name,string email,string location,string phoneNumber,string restaurantName,string comment,byte rating,int id)
        {
            this.name = name;
            this.email = email;
            this.location = location;
            this.phoneNumber = phoneNumber;
            this.restaurantName = restaurantName;
            this.comment = comment;
            this.rating = rating;
            this.id = id;
 

        }
        public void Display()
        {
            Console.WriteLine("Customer name is {0}", name);
            Console.WriteLine("Customer email is {0}", email);
            Console.WriteLine("Customer  location is {0}", location);
            Console.WriteLine("Customer phone number is {0}", phoneNumber);
            Console.WriteLine("The restaurant name is {0}",restaurantName);
            Console.WriteLine("Customer review is {0}", comment);
            Console.WriteLine("Customer rating is {0}", rating);
            Console.WriteLine("Customerid is {0}", id);

        }

    }
}
