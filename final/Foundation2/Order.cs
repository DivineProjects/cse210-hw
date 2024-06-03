using System;
using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> _productsList;
    private Customer _customer;

    // Constructer
    public Order(Customer customer)
    {
        _productsList = new List<Product>();
        _customer = customer;
    }
    // Set Methods
    public void SetOrderProduct (Product product)
    {
        _productsList.Add(product);
    }

    // Method to calculate the total cost of the order
    public double CalculateTotalCost()
    {
        double totalCost = 0;
        foreach (var product in _productsList)
        {
            totalCost += product.GetPrice();
        }

        // Add the shipping cost
        double shippingCost = _customer.LivesInUSA() ? 5.0 : 35.0;
        totalCost += shippingCost;

        return totalCost;
    }

    // Method to generate the packing label
    public string GeneratePackingLabel()
    {
        StringBuilder packingLabel = new StringBuilder();
        packingLabel.AppendLine("Packing Label:");
        foreach (var product in _productsList)
        {
            packingLabel.AppendLine($"Name: {product.GetProductName()}, Product ID: {product.GetProductId()}");
        }
        return packingLabel.ToString();
    }

    // Method to generate the shipping label
    public string GenerateShippingLabel()
    {
        StringBuilder shippingLabel = new StringBuilder();
        shippingLabel.AppendLine("Shipping Label:");
        shippingLabel.AppendLine($"Name: {_customer.GetName()}");
        shippingLabel.AppendLine(_customer.GetAddress().GetAddress());
        return shippingLabel.ToString();
    }




    
}