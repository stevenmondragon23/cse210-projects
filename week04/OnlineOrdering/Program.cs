using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("Alice Johnson", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P001", 1000, 1));
        order1.AddProduct(new Product("Mouse", "P002", 25, 2));

        Address address2 = new Address("456 Avenida Siempre Viva", "Lima", "Lima", "Peru");
        Customer customer2 = new Customer("Carlos Fernández", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Tablet", "P003", 400, 1));
        order2.AddProduct(new Product("Headphones", "P004", 60, 1));
        order2.AddProduct(new Product("USB Cable", "P005", 10, 3));

        Address address3 = new Address("789 Sunset Blvd", "Los Angeles", "CA", "USA");
        Customer customer3 = new Customer("Emily Smith", address3);
        Order order3 = new Order(customer3);
        order3.AddProduct(new Product("Smartphone", "P006", 800, 1));
        order3.AddProduct(new Product("Charger", "P007", 20, 2));

        Address address4 = new Address("101 Oxford St", "London", "London", "UK");
        Customer customer4 = new Customer("James Brown", address4);
        Order order4 = new Order(customer4);
        order4.AddProduct(new Product("Camera", "P008", 600, 1));
        order4.AddProduct(new Product("Tripod", "P009", 45, 1));

        Address address5 = new Address("202 Market St", "Chicago", "IL", "USA");
        Customer customer5 = new Customer("Michael Johnson", address5);
        Order order5 = new Order(customer5);
        order5.AddProduct(new Product("Printer", "P010", 200, 1));
        order5.AddProduct(new Product("Ink Cartridge", "P011", 40, 2));
        order5.AddProduct(new Product("Paper Pack", "P012", 15, 5));

        Order[] orders = { order1, order2, order3, order4, order5 };

        int i = 1;
        foreach (var order in orders)
        {
            Console.WriteLine($"=== Order {i} ===");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order.GetTotalCost()}\n");
            i++;
        }
    }
}
