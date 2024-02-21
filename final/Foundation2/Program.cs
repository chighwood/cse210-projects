using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        Product product1 = new Product("Buns", 1, 2.57, 1);
        Product product2 = new Product("Cheese", 2, 4.89, 1);
        Product product3 = new Product("Pears", 3, 1.50, 1);
        Product product4 = new Product("Sausages", 4, 9.99, 1);
        Product product5 = new Product("Milk", 5, 3.18, 1);


        Address address1 = new Address("1587 NW Town St", "Mayor", "KY", "USA");
        Address address2 = new Address("1501 Main St.", "Henderson", "NV", "USA");
        Address address3 = new Address("346 Blanco Dr.", "Hamburg", " ", "Germany");


        Customer customer1 = new Customer("Joseph Smith", address1);
        Customer customer2 = new Customer("Frank Beatles", address2);
        Customer customer3 = new Customer("Silvester Muller", address3);

        // Order # 1
        List<Product> productsOrder1 = new List<Product> { product1, product2, product5, product3};
        Order order1 = new Order(productsOrder1, customer1);

        Console.WriteLine("=============================");
        Console.WriteLine("Order 1 Information:\n");
        Console.WriteLine("Packing Label:\n-------------------\n" + order1.GeneratePackingLabel());
        Console.WriteLine("Shipping Label:\n-------------------\n" + order1.GenerateShippingLabel());
        Console.WriteLine("Total Cost: $" + order1.CalcTotalCost() + "\n\n");

        // Order # 2
        List<Product> productsOrder2 = new List<Product> { product2, product2, product5, product4, product1};
        Order order2 = new Order(productsOrder2, customer2);

        Console.WriteLine("=============================");
        Console.WriteLine("Order 2 Information:\n");
        Console.WriteLine("Packing Label:\n-------------------\n" + order2.GeneratePackingLabel());
        Console.WriteLine("Shipping Label:\n-------------------\n" + order2.GenerateShippingLabel());
        Console.WriteLine("Total Cost: $" + order2.CalcTotalCost() + "\n\n");

        // Order # 3
        List<Product> productsOrder3 = new List<Product> { product4, product4, product4, product5, product1, product2};
        Order order3 = new Order(productsOrder3, customer3);

        Console.WriteLine("=============================");
        Console.WriteLine("Order 3 Information:\n");
        Console.WriteLine("Packing Label:\n-------------------\n" + order3.GeneratePackingLabel());
        Console.WriteLine("Shipping Label:\n-------------------\n" + order3.GenerateShippingLabel());
        Console.WriteLine("Total Cost: $" + order3.CalcTotalCost() + "\n\n");

    }
}