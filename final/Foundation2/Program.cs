using System;

class Program
{
    static void Main(string[] args)
    {
        Address ad1 = new Address("12345 H Rd.", "Springfield", "OH", "USA");
        Address ad2 = new Address("98765 Drive Blvd.", "Moscow", "", "China");

        Customer cust1 = new Customer("Bobby Big", ad1);
        Customer cust2 = new Customer("Little Sleepy", ad2);

        Product prod1 = new Product("Xbox", 1313, 12.33, 60);
        Product prod2 = new Product("Door", 1888, 600.67, 2);
        Product prod3 = new Product("Cow", 2281, 3.99, 777);
        Product prod4 = new Product("Moon", 5145, 0.01, 1);

        List<Product> prods1 = new List<Product>();
        prods1.Add(prod1);
        prods1.Add(prod2);
        List<Product> prods2 = new List<Product>();
        prods2.Add(prod3);
        prods2.Add(prod4);

        Order ord1 = new Order(prods1, cust1);
        Order ord2 = new Order(prods2, cust2);

        Console.WriteLine("Order 1");
        Console.WriteLine($"Packing Lable: {ord1.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label: {ord1.GetShippingLabel()}");
        Console.WriteLine($"Total Cost: {ord1.GetCost()}");

        Console.WriteLine("Order 2");
        Console.WriteLine($"Packing Lable: {ord2.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label: {ord2.GetShippingLabel()}");
        Console.WriteLine($"Total Cost: {ord2.GetCost()}");
    }
}