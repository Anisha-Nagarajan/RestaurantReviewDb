using System;
using System.Data.SqlClient;
using System.Configuration;

namespace RestaurantReview
{
    class UserLogin
    {
        
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        public void CustomerLogin()
        {
            LoginOperations loginOperations = new LoginOperations();
            Validation validate = new Validation();
            Console.WriteLine("Choose the operation to be performed\n 1.Sign in\n 2.Create new account\n 3.Exit");
                byte choice = Convert.ToByte(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        
                        Console.WriteLine("Enter user name");
                        string userName = Console.ReadLine();
                        Console.WriteLine("Enter password");
                        string password = Console.ReadLine();
                        //LoginDetails user = new LoginDetails(userName, password, "user");
                        //loginOperations.Validate(user);
                        break;
                    case 2:
                    UserLogin newaccount = new UserLogin();
                    newaccount.NewAccount();

                    break;
                    case 3:
                        break;
                }
      
            
        }
        public void NewAccount()
        {
            Console.WriteLine("Choose\n 1.Customer\n 2.HotelOwner");
            byte value = Convert.ToByte(Console.ReadLine());
            string sp, user;
            if (value == 1)
            {
                sp = "InsertCustomer";
                user = "Customer";
            }
            else
            {
                sp = "InsertHotelOwner";
                user = "HotelOwner";
            }

            Console.WriteLine("Enter user name");
            string NewUserName = Console.ReadLine();
            Console.WriteLine("Enter password");
            string NewPassword = Console.ReadLine();
            //LoginDetails newUser = new LoginDetails(NewUserName, NewPassword,"user");
            //loginOperations.CreateAccount(newUser);
            using (SqlCommand command = new SqlCommand(sp, connection))
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserName", NewUserName);
                command.Parameters.AddWithValue("@Password", NewPassword);
                command.Parameters.AddWithValue("@Role", user);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
