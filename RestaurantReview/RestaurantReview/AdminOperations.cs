using System;
using System.Collections.Generic;


namespace RestaurantReview
{
    class AdminOperations
    {
        public static List<RestaurantDetails> restaurantList = new List<RestaurantDetails>();
        public void AddRestautant(RestaurantDetails restaurant)
        {
            restaurantList.Add(restaurant);
            Console.WriteLine("Restaurant list has been updated");
        }
        public void BindRestaurantDetails()
        {
            RestaurantDetails restaurantDetail;
            restaurantDetail = new RestaurantDetails("Taj", "Veg & Non-Veg",1,"Kaviya","Gandhi street","karur","Tamil Nadu",639004);
            restaurantList.Add(restaurantDetail);
            restaurantDetail = new RestaurantDetails("Rasikas", "Veg",2,"Kavin","Pillaiyar street","coimbatore","Tamil Nadu",623942);
            restaurantList.Add(restaurantDetail);
            restaurantDetail = new RestaurantDetails("Shawarama station", "Veg", 3,"Kayalvizhi","Teacher's colony","Madurai","Tamil Nadu",674732);
            restaurantList.Add(restaurantDetail);
            restaurantDetail = new RestaurantDetails("Anjappar", "Non-Veg", 4,"Appu","Anbu Nagar","Salem","Tamil Nadu",636008);
            restaurantList.Add(restaurantDetail);
            restaurantDetail = new RestaurantDetails("Saravana Bhavan", "Veg & Non-Veg", 5,"Subash","Vj street","Erode","Tamil Nadu",657743);
            restaurantList.Add(restaurantDetail);
            restaurantDetail = new RestaurantDetails("Barbequeue", "Non-Veg",6,"Karthika","Velu street","Coimbatore","Tamil Nadu",674543);
            restaurantList.Add(restaurantDetail);
            restaurantDetail = new RestaurantDetails("Selvi Mess", "Non-Veg",7,"Sindhiya","Nivash colony","Namakkal","Tamil Nadu",645453);
            restaurantList.Add(restaurantDetail);

        }
        public void DeleteRestaurant(string restaurantName)
        {
            RestaurantDetails value = null;
            foreach (RestaurantDetails restaurant in restaurantList)
            {

                if (restaurant.restaurantName.Contains(restaurantName))
                {
                    Console.WriteLine("True");
                    value = restaurant;

                }

            }
            if (value != null)
            {
                restaurantList.Remove(value);
            }

        }
        public void SearchRestaurants(string location)
        {
            Console.WriteLine("The nearby restaurants are");
            foreach(RestaurantDetails restaurant in restaurantList)
            {
                if (restaurant.city.Contains(location))
                {
                    Console.WriteLine("True");
                    restaurant.Display();
                }
            }


        }
        public void Display()
        {
            foreach (RestaurantDetails retaurant in restaurantList)
                retaurant.Display();
        }
      
    }
}
