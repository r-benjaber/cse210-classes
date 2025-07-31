public class Customer
{
    private string _name;
    private Address _address;

    public Customer()
    {
        _name = "Unknown";
        _address = new Address();
    }

        public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetFullAddress()
    {
        return _address.GetFullAddress();
    }

    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }
}
