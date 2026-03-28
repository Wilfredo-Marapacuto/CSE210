using System;

class Program
{
    static void Main(string[] args)
    {
        Address usaAddress = new Address("123 Main St", "Provo", "UT", "USA");
        Customer usaCustomer = new Customer("John Smith", usaAddress);

        Order order1 = new Order(usaCustomer);
        order1.AddProduct(new Product("Laptop", "P100", 899.99, 1));
        order1.AddProduct(new Product("Mouse", "P101", 25.50, 2));
        order1.AddProduct(new Product("Keyboard", "P102", 45.00, 1));

        Address internationalAddress = new Address("456 Central Ave", "Bogota", "Cundinamarca", "Colombia");
        Customer internationalCustomer = new Customer("Maria Gomez", internationalAddress);

        Order order2 = new Order(internationalCustomer);
        order2.AddProduct(new Product("Phone", "P200", 699.99, 1));
        order2.AddProduct(new Product("Charger", "P201", 19.99, 2));
        order2.AddProduct(new Product("Headphones", "P202", 89.99, 1));

        Console.WriteLine("ORDER 1");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():F2}");
        Console.WriteLine();

        Console.WriteLine("ORDER 2");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():F2}");
    }
}