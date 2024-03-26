using System;
using Foundation2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("FOUNDATION 2:\n");

        //Products
        Product product1 = new Product("Shirt", "T0001", 10.99, 5);
        Product product2 = new Product("Socks", "T0002", 5.99, 10);
        Product product3 = new Product("Pants", "T0003", 15.99, 7);
        Product product4 = new Product("Jacket", "T0004", 25.99, 3);
        Product product5 = new Product("Shoes", "T0005", 35.99, 2);
        Product product6 = new Product("Sweater", "T0006", 20.99, 4);

        //Addresses
        Address address1 = new Address("123 Main St", "Boise", "ID", "USA");
        Address address2 = new Address("Carrera 43A #5A-113", "Medellin", "Antioquia", "Colombia");

        //Customers
        Customer customer1 = new Customer("Brother Thayne", address1);
        Customer customer2 = new Customer("Andres Castro", address2);

        //Orders
        List<Product> productsList1 = new List<Product>();
        productsList1.Add(product1);
        productsList1.Add(product2);
        productsList1.Add(product3);
        Order order1 = new Order(productsList1, customer1);
        Console.WriteLine("Order 1: ");
        order1.PackagingLabel();
        order1.ShippingLabel();
        order1.OrderTotalCost();

        List<Product> productsList2 = new List<Product>();
        productsList2.Add(product4);
        productsList2.Add(product5);
        productsList2.Add(product6);
        Order order2 = new Order(productsList2, customer2);
        Console.WriteLine("\nOrder 2: ");
        order2.PackagingLabel();
        order2.ShippingLabel();
        order2.OrderTotalCost();


    }
}