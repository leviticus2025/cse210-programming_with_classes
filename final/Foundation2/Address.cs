public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }
    public bool InUSA()
    {
        return _country.ToLower() == "usa" || _country.ToLower() == "united states";
        // I used the or syntax...I learned that in my fundamental digital systems class earlier this semester haha
    }
    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }
}