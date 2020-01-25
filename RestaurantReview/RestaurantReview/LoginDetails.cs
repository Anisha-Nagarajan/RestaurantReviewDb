using System;


namespace RestaurantReview
{
    class LoginDetails
    {
       
        
        public string userName { get; set; }
        public string password { get; set; }
        public string role { get; set; }

        public LoginDetails(string userName, string password,string role)
        {
            this.userName = userName;
            this.password = password;
            this.role = role;    
        }

       

    }
}
