using System;

class Program
{
    static void Main(string[] args)
    {
        // Dirección en USA
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("Alice Johnson", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P001", 1000, 1));
        order1.AddProduct(new Product("Mouse", "P002", 25, 2));

        // Dirección fuera de USA
        Address address2 = new Address("456 Avenida Siempre Viva", "Lima", "Lima", "Peru");
        Customer customer2 = new Customer("Carlos Fernández", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Tablet", "P003", 400, 1));
        order2.AddProduct(new Product("Headphones", "P004", 60, 1));
        order2.AddProduct(new Product("USB Cable", "P005", 10, 3));

        // Mostrar pedidos
        Console.WriteLine("=== Order 1 ===");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}\n");

        Console.WriteLine("=== Order 2 ===");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}\n");
    }
}
