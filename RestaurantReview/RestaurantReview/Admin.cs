using System;
using System.Data.SqlClient;
using System.Configuration;

namespace RestaurantReview
{
    class Admin
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        public void AdminChoice()
        {
            AdminOperations adminOperation = new AdminOperations();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Choose the operation you need to perform\n 1.Add Restaurant \n 2.Delete Restaurant\n 3.View Restaurant\n 4.Exit");
                byte choice = Convert.ToByte(Console.ReadLine());
                switch (choice)
                { 
                    case 1:

                        //RestaurantDetails restaurant = new RestaurantDetails(name, type, registrationNo,restaurantOwner,streetName,city,state,pincode);
                        //adminOperation.AddRestautant(restaurant);
                        Admin admin = new Admin();
                        admin.RegisterRestaurant();
                        break;
                    case 2:
                        Console.WriteLine("Enter the name of the restaurant you want to delete");
                        string restaurantName = Console.ReadLine();
                        adminOperation.DeleteRestaurant(restaurantName);
                        break;
                    case 3:
                        Console.WriteLine("The restaurant details are");
                        adminOperation.Display();
                        break;
                
                    case 4:
                        flag = false;
                        Console.WriteLine("Thank you!");
                        break;
                }
            }

        }
        public void RegisterRestaurant()
        {
            Console.WriteLine("Enter restaurant name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter retaurant type veg or non-veg");
            string type = Console.ReadLine();
            Console.WriteLine("Enter restaurant registration number");
            int registrationNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name of the restaurant owner");
            string restaurantOwner = Console.ReadLine();
            Console.WriteLine("Enter street name");
            string streetName = Console.ReadLine();
            Console.WriteLine("Enter city");
            string city = Console.ReadLine();
            Console.WriteLine("Enter state");
            string state = Console.ReadLine();
            Console.WriteLine("Enter pincode");
            int pincode = Convert.ToInt32(Console.ReadLine());
            using (SqlCommand command = new SqlCommand("AddRestaurantDetails", connection))
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Type", type);
                command.Parameters.AddWithValue("@RegNo", registrationNo);
                command.Parameters.AddWithValue("@Owner", restaurantOwner);
                command.Parameters.AddWithValue("@StreetName", streetName);
                command.Parameters.AddWithValue("@City", city);
                command.Parameters.AddWithValue("@State", state);
                command.Parameters.AddWithValue("@Pincode", pincode);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
