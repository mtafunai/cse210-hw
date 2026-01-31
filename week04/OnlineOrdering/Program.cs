using System;
using System.Net.Http.Headers;
using System.Net.Sockets;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Address address1 = new Address("123 Main St", "Dallas", "Tx", "ÜSA");
        Customer customer1 = new Customer("Sam Smith", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Book", "B101", 12.99,2));
        order1.AddProduct(new Product("Pen", "P202", 1.50, 5));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice()}");
        Console.WriteLine();

        Address address2 = new Address("45 King St", "Auckland", "AKL", "New Zealand");
        customer customer2 = new customer("Mary Lee", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Notebook", "N303", 5.99, 3));
        order2.AddProduct(new Product("Backpack", "BP404", 39.99, 1));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}");


    }

}