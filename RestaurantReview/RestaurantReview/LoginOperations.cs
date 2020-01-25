using System;
using System.Collections.Generic;

namespace RestaurantReview
{
 
    class LoginOperations
    {
        public static List<LoginDetails> usersList = new List<LoginDetails>();
        UserLogin login = new UserLogin();
     
      static LoginOperations()
        {
            LoginOperations loginoperations = new LoginOperations();
            loginoperations.BindLoginDetails();
            AdminOperations adminOperations = new AdminOperations();
            adminOperations.BindRestaurantDetails();
           
        }
    public void BindLoginDetails()
    {
            LoginDetails loginDetail;
            loginDetail=new LoginDetails("Akhil", "aki123","user");
            usersList.Add(loginDetail);
            loginDetail = new LoginDetails("Saranya","saran123","admin");
            usersList.Add(loginDetail);
            loginDetail = new LoginDetails("Rithvik", "rithu123","admin");
            usersList.Add(loginDetail);
            loginDetail = new LoginDetails("Aarthika", "aarthi123","user");
            usersList.Add(loginDetail);
        }
      
        public void AddUser(LoginDetails user) 
        {
            usersList.Add(user);
        }
        public void Validate(LoginDetails user)
        {
            foreach (LoginDetails loginDetails in usersList)
            {

                if ((loginDetails.userName == user.userName) && (loginDetails.password == user.password) && (loginDetails.role == user.role))
                {
                    Console.WriteLine("You have successfully logged in");
                    break;

                }
                else
                {
                    Console.WriteLine("Login failed.Please try again");
                    login.CustomerLogin();
                }
            }
            
        }
        public void CreateAccount(LoginDetails newUser)
        {
            usersList.Add(newUser);
            Console.WriteLine("You have successfully created your account");
            Validate(newUser);
        }
        

    }
}
