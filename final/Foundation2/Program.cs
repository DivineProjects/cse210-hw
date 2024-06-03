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

        // Create a new address object
            // Address myAddress = new Address("123 Main St", "Springfield", "IL", "USA");

            // Create a new customer object
            // Customer myCustomer = new Customer("John Doe", myAddress);

            // Create a new order object
            Order myOrder = new Order(myCustomer);

            // Add products to the order
            Product product1 = new Product("Laptop", "12345", 999.99F);
            Product product2 = new Product("Mouse", "67890", 49.99F);
            myOrder.SetOrderProduct(product1);
            myOrder.SetOrderProduct(product2);

            // Display the total cost of the order
            Console.WriteLine($"Total Cost: ${myOrder.CalculateTotalCost()}");

            // Generate and display the packing label
            Console.WriteLine("\nPacking Label:");
            Console.WriteLine(myOrder.GeneratePackingLabel());

            // Generate and display the shipping label
            Console.WriteLine("\nShipping Label:");
            Console.WriteLine(myOrder.GenerateShippingLabel());
    }
}