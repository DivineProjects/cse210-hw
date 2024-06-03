using System;
using System.Collections.Generic;

public class Customer
{
    private string _name;
    private Address _address = new Address();
    // constructor
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // methods
    //determine if the customer lives in the USA
    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }

    // methods
    public void SetName(string name)
    {
        _name = name;
    }

    public void SetAddress(Address address)
    {
        _address = address;
    }

    // Get methods
    public string GetName()
    {
        return _name;
    }

    public Address GetAddress()
    {
        return _address;
    }

    public void DisplayCustomerInfo()
    {
        Console.WriteLine($"Name: {_name} \nAddress: {_address.GetAddress()}");
    }

}