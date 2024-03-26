using Foundation2;

public class Order{
    public List<Product> _productsList { get; set; }
    public Customer _customer { get; set; }

    public Order(List<Product> productsList, Customer customer)
    {
        _productsList = productsList;
        _customer = customer;
    }

    public void OrderTotalCost(){
        double totalCost = 0;
        foreach(Product product in _productsList){
            totalCost += product.TotalCost(product._quantity, product._unitPrice);
            if(_customer.IsInUSA()){
                totalCost += 5;
            }
            else{
                totalCost += 35;
            }
        }
        Console.WriteLine($"Total cost: ${Math.Round(totalCost,2)}"); 
    }

    public void PackagingLabel(){
        Console.WriteLine("Products: ");
        foreach(Product product in _productsList){
            Console.WriteLine($"{product._productName} - {product._productID}");  
        }
    }
    public void ShippingLabel(){
        Console.WriteLine($"Ship to: {_customer._customerName} - {_customer._address.GetFullAddress()}");
    }



   
}