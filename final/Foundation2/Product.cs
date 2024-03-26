namespace Foundation2;

public class Product
{
    public string _productName { get; set; }
    public string _productID { get; set; }
    public double _unitPrice { get; set; }
    public int _quantity { get; set; }

    public Product(string productName, string productID, double unitPrice, int quantity)
    {
        _productName = productName;
        _productID = productID;
        _unitPrice = unitPrice;
        _quantity = quantity;
    }

    public double TotalCost(int q, double p){
        return q * p;
    }

    
}
