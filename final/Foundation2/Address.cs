using System;

public class Address
{
    
    private string _street;
    private string _city;
    private string _stateProvince; 
    private string _country;
    //constructor
    public Address()
    {
        _street = "";
        _city = "";
        _stateProvince = "";
        _country = "";
    }

    public Address(string street, string city, string stateProvince, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }
    // settters
    public string SetStreet(string street)
    {
        return _street;
    }

    public string SetCity(string city)
    {
        return _city;
    }

    public string SetStateProvince(string stateProvince)
    {
        return _stateProvince;
    }

    public string GetCountry(string country)
    {
        return _country;
    }

    // methods
    public string GetAddress()
    {
        return $"Steet: {_street}\nCity: {_city}, {_stateProvince}\nCountry: {_country}";
    }

    // Method to determine if the address is in the USA
    public bool IsInUSA()
    {
        return _country.ToLower() == "usa" || _country.ToLower() == "united states";
    }
    

}