public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order()
    {
        _customer = new Customer();
        _products = new List<Product>();
    }

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public float GetTotalCost()
    {
        float totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.TotalCost();
        }
        if (_customer.LivesInUSA())
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }
        return totalCost;
    }

    public void DisplayPackingLabel()
    {
        foreach (Product product in _products)
        {
            Console.WriteLine($"{product.GetName()} {product.GetProductId()} P:{product.GetPrice():C} x{product.GetAmount()}    {product.TotalCost():C}");
        }
        if (_customer.LivesInUSA())
        {
            Console.WriteLine("Shipping Cost: $5");
        }
        else
        {
            Console.WriteLine("Shipping Cost: $35");
        }
        Console.WriteLine($"TOTAL:     {GetTotalCost():C}");
    }

    public void DisplayShippingLabel()
    {
        Console.WriteLine($"Shipped to {_customer.GetName()} in {_customer.GetFullAddress()}.");
    }

    public void DisplayTicket()
    {
        Console.WriteLine("------Thank you for buying with us------");
        Console.WriteLine($"Customer Name: {_customer.GetName()}");
        Console.WriteLine("Buying List:");
        Console.WriteLine("Product - Id - Price - Amount - Total");
        Console.WriteLine("----------------------------------------");
        DisplayPackingLabel();
        DisplayShippingLabel();
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("-------We hope you come back soon-------");
        Console.WriteLine();
    }

}