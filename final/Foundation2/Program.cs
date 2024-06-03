using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        //------------ FIRST CUSTOMER ORDER ---------------------------------------
        Console.WriteLine("\n------------ FIRST CUSTOMER ORDER ---------------------------------------");
        // Create a new address object
        Address address = new Address("60 River St", "Sweet Valley", "NY", "USA");
        // Create a new customer object
        Customer customer = new Customer("John Doe", address);
        // Create a new order object
        Order order = new Order(customer);
        // Create Products
        Product product1 = new Product("Dress", "564553", 50F);
        Product product2 = new Product("Perfume", "154334", 100F);
        // Add products to the order
        order.SetOrderProduct(product1);
        order.SetOrderProduct(product2);
        // Display the total cost of the order
        Console.WriteLine($"Total Cost: ${order.CalculateTotalCost()}");
        // Generate and display the packing label
        Console.WriteLine(order.GeneratePackingLabel());
        // Generate and display the shipping label
        Console.WriteLine(order.GenerateShippingLabel());
        //=======================================================================



        //------------------ SECOND CUSTOMER ORDER -------------------------------
        Console.WriteLine("\n------------ SECOND CUSTOMER ORDER ---------------------------------------");
        Address address2 = new Address("19 Fort St", "Bulawayo", "BYO", "Zimbabwe");
        Customer customer2 = new Customer("Tani Dube", address2);
        // Create a new order object
        Order order2 = new Order(customer2);  
        // Create Products
        Product product3 = new Product("Book", "6789043", 50F);
        Product product4 = new Product("Bag", "565675", 100F);
        // Add products to the order
        order2.SetOrderProduct(product3);
        order2.SetOrderProduct(product4);
        // Display the total cost of the order
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}");
        // Generate and display the packing label
        Console.WriteLine(order2.GeneratePackingLabel());
        // Generate and display the shipping label
        Console.WriteLine(order2.GenerateShippingLabel());
    }
}