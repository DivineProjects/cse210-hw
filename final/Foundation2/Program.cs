using System;

class Program
{
    static void Main(string[] args)
    {
       // Create a new address object
            Address myAddress = new Address("123 Main St", "Springfield", "IL", "USA");

            // Create a new customer object
            Customer myCustomer = new Customer("John Doe", myAddress);

            // Display customer details
            Console.WriteLine("Customer Details:");
            myCustomer.DisplayCustomerInfo();

            // Check if the customer lives in the USA
            Console.WriteLine("\nDoes the customer live in the USA?");
            Console.WriteLine(myCustomer.LivesInUSA() ? "Yes" : "No");

            // Modify the address and update the customer
            Address newAddress = new Address("456 Elm St", "Chicago", "IL", "Canada");
            myCustomer.SetAddress(newAddress);

            // Display updated customer details
            Console.WriteLine("\nUpdated Customer Details:");
            myCustomer.DisplayCustomerInfo();

            // Check if the updated address is in the USA
            Console.WriteLine("\nDoes the customer live in the USA?");
            Console.WriteLine(myCustomer.LivesInUSA() ? "Yes" : "No");
    }
}