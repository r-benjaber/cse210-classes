public class Address
{
    private string _address;
    private string _city;
    private string _state;
    private string _country;

    public Address()
    {
        _address = "Unknown";
        _city = "Unknown";
        _state = "Unknown";
        _country = "Unknown";
    }

    public Address(string address, string city, string state, string country)
    {
        _address = address;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsInUSA()
    {
        List<string> usa = new List<string> { "usa", "u.s.a.", "united states", "united states of america" };
        if (usa.Contains(_country.ToLower()))
        {
            return true;
        }
        return false;
    }

    public string GetFullAddress()
    {
        return $"{_address}, {_city}, {_state}, {_country}";
    }
}