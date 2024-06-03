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
        string packingLabel = "Packing Label:\n";
        foreach (var product in _productsList)
        {
            packingLabel += $"Product Name: {product.GetProductName()}, Product ID: {product.GetProductId()}\n";
        }
        return packingLabel;
    }

    // // Method to generate the shipping label
    // public string GenerateShippingLabel()
    // {
    //     StringBuilder shippingLabel = new StringBuilder();
    //     shippingLabel.AppendLine("Shipping Label:");
    //     shippingLabel.AppendLine($"Name: {_customer.GetName()}");
    //     shippingLabel.AppendLine(_customer.GetAddress().GetAddress());
    //     return shippingLabel.ToString();
    // }

    // Method to generate the shipping label
    public string GenerateShippingLabel()
    {
        string shippingLabel = "Shipping Label:\n";
        shippingLabel += _customer.GetCustomerInfo();
        return shippingLabel;
    }




    
}