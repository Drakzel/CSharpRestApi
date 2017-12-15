using CustomerAppBLL;
using CustomerAppBLL.BusinessObjects;
using System;

namespace CustomerAppUI
{
    class Program
    {
        static BLLFacade bllFacade = new BLLFacade();

        static void Main(string[] args)
        {
            Console.WriteLine(
                "Select your option.\n" +
                "\n" +
                "1. Get all customers.\n" +
                "2. Create a new customer\n");

            string input = Console.ReadLine();
            Int32.TryParse(input, out int selectedNumber);
            switch (selectedNumber)
            {
                default:
                    Console.WriteLine("Invalid input.");
                    break;
                case 1:
                    bllFacade.CustomerService.GetAll();
                    break;
                case 2:
                    CustomerBO cust = new CustomerBO();
                    Console.WriteLine("Enter address.");
                    cust.Address = Console.ReadLine();

                    Console.WriteLine("Enter first name.");
                    cust.FirstName = Console.ReadLine();

                    Console.WriteLine("Enter last name.");
                    cust.LastName = Console.ReadLine();

                    bllFacade.CustomerService.Create(new CustomerBO
                    {
                        Address = cust.Address,
                        FirstName = cust.FirstName,
                        LastName = cust.LastName
                    });
                    break;
            }
            Console.ReadLine();
        }
    }
}
