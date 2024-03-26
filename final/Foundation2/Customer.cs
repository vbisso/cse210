namespace Foundation2;

public class Customer
{
    public string _customerName { get; set; }
    public Address _address { get; set; }

    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }

    public bool IsInUSA()
    {
        return _address._country == "USA";
    }

}
