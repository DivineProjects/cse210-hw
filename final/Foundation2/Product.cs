using System;

public class Product
{
    private string _name; 
    private string _productId;
    private float _price; 
    private int _quantity;

    public Product(string name, string productId, float price)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = 0;
    }

    public void SetProductQuantity(int quantity)
    {
        _quantity = quantity;
    }

    public string GetProductName()
    {
        return _name;
    }

    public float GetPrice()
    {
        return _price;
    }

    public string GetProductId()
    {
        return _productId;
    }

    public float ProductTotalCost()
    {
        return _price * _quantity;
    }

}