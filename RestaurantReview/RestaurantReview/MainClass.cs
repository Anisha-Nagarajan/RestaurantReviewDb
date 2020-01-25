using System;


namespace RestaurantReview
{
    class MainClass
    {
        

        public void GetDetails()
        {
            Validation validate = new Validation();
            validate.GetName();
            validate.GetEmail();
            validate.GetLocation();
            validate.GetPhoneNumber();
            validate.GetRestaurantName();
            validate.GetComment();
            validate.GetRating();
        }

        static void Main(string[] args)
        {
            CustomerOperations operation = new CustomerOperations();   
            LoginOperations loginoperations = new LoginOperations();
            Admin admin = new Admin();
            admin.AdminChoice();
            UserLogin user = new UserLogin();
            user.CustomerLogin();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Choose the operation you need to perform\n 1.Register\n 2.Delete Customer\n 3.View Customer 4.Search nearby restaurants  5.Exit");
                byte choice = Convert.ToByte(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        MainClass program = new MainClass();
                        program.GetDetails();
                        break;
                    case 2:
                        Console.WriteLine("Enter the name of the customer you want to delete");
                        string CustomerName = Console.ReadLine();
                        operation.DeleteCustomer(CustomerName);
                        break;
                    case 3:
                        Console.WriteLine("The customer details are");
                        operation.Display();
                        break;
                    case 4:
                        Console.WriteLine("Enter your location");
                        string location = Console.ReadLine();
                        AdminOperations adminOperation = new AdminOperations();
                        adminOperation.SearchRestaurants(location);
                        break;

                    case 5:
                        flag = false;
                        Console.WriteLine("Thank you.Have a great day!");
                        break;
                }
            }

        }
    }
}
