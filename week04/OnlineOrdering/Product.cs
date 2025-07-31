using System.Globalization;

public class Product
{
    private string _name;
    private string _productId;
    private float _price;
    private int _amount;

    public Product()
    {
        _name = "Unknown";
        _productId = "Unknown";
        _price = 0;
        _amount = 0;
    }

    public Product(string name, string productId, float price, int amount)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _amount = amount;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetProductId()
    {
        return _productId;
    }

    public float GetPrice()
    {
        return _price;
    }

    public int GetAmount()
    {
        return _amount;
    }

    public float TotalCost()
    {
        return (float)_amount * _price;
    }
}