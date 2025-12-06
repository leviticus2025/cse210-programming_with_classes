public class Product
{
    private string _name;
    private string _productID;
    private float _pricePerUnit;
    private int _quantity;
    public Product(string name, string productID, float pricePerUnit, int quantity)
    {
        _name = name;
        _productID = productID;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }
    public float GetTotalCost()
    {
        return _pricePerUnit * _quantity;
    }
    public string GetPackingInfo()
    {
        return $"{_name} (ID: {_productID}) - Quantity: {_quantity} @ ${_pricePerUnit} each";
    }
}
