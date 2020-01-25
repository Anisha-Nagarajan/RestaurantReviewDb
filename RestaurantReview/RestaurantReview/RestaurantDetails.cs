using System;
 

namespace RestaurantReview
{
    class RestaurantDetails
    {
        public string restaurantName { get; set; }
        public string restaurantType { get; set; }
        public int restaurantRegNo { get; set; }
        public string restaurantOwner { get; set; }
        public string streetName { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int pincode { get; set; }

        public RestaurantDetails(string restaurantName, string restaurantType, int restaurantRegNo,string restaurantOwner,
            string streetName,string city,string state, int pincode)
        {
            this.restaurantName = restaurantName;
            this.restaurantType = restaurantType;
            this.restaurantRegNo=restaurantRegNo;
            this.restaurantOwner = restaurantOwner;
            this.streetName = streetName;
            this.city = city;
            this.state = state;
            this.pincode = pincode;
        } 
        public void Display()
        {
            Console.WriteLine("The restaurant name is {0}", restaurantName);
            Console.WriteLine("The restaurant type is {0}", restaurantType);
            Console.WriteLine("The restaurant registration number is {0}", restaurantRegNo);
            Console.WriteLine("The restaurant owner is {0}", restaurantOwner);
            Console.WriteLine("The address of the restaurant is {0}\n{1}\n{2}\n{3}",streetName,city,state,pincode);
        }

    }
}
