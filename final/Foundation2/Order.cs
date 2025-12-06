public class Order
{
    private Customer _customer;
    private List<Product> _products;
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
        float total = 0;
        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }
        float shipping = _customer.LivesInUSA() ? 5f : 35f;
        Console.WriteLine("Includes $5 shipping cost for USA and $35 for outside the USA");
        return total + shipping;
    }
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in _products)
        {
            label += $"{product.GetPackingInfo()}\n";
        }
        return label;
    }
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}