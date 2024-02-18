using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");

        
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        
        Product product1 = new Product("Widget", "W123", 10, 2);
        Product product2 = new Product("Gadget", "G456", 20, 1);

       
        List<Product> orderProducts1 = new List<Product> { product1, product2 };
        Order order1 = new Order(customer1, orderProducts1);

        List<Product> orderProducts2 = new List<Product> { product2 };
        Order order2 = new Order(customer2, orderProducts2);

    
        Console.WriteLine("Order 1 Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("\nOrder 1 Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("\nOrder 1 Total Price:");
        Console.WriteLine(order1.CalculateTotalPrice());

        Console.WriteLine("\nOrder 2 Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("\nOrder 2 Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("\nOrder 2 Total Price:");
        Console.WriteLine(order2.CalculateTotalPrice());
    }
}