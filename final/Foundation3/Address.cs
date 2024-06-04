using System;

class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _countryip;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public override string ToString()
    {
        return $"\n{_street}\n{_city} \n{_state} \n{_country}";
    }
}
