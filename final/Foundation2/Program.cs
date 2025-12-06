using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Samsung \"85\" TV", "1212321I1", 1199.99f, 1);
        Product product2 = new Product("GoPro Hero 13", "121284786B", 280.00f, 1);
        Product product3 = new Product("Audio_Technica Headphones", "6758439A-1T", 110.99f, 2);
        Product product4 = new Product("Ergonomic Mesh Gaming Chair", "MOC7181", 199.99f, 1);
        Product product5 = new Product("Pineapple Mango Juice - 32oz", "420011PM", 6.99f, 3);
        Product product6 = new Product("Anker Portable Waterproof Speaker", "PBS115691", 45.00f, 2);
        Product product7 = new Product("Ultra-Soft King Size Fleece Blanket", "DCS93311", 68.95f, 1);
        Product product8 = new Product("Adjustable Dumbbell Set (50 lbs)", "ASDJ26009", 299.99f, 1);
        Product product9 = new Product("Hydrating Face Serum Lotion", "HFSL9078947", 32.75f, 2);

        Customer customer1 = new Customer("Levi Beasley", new Address("1321 Tiona Lane", "Towny", "CA 90210", "USA"));
        Customer customer2 = new Customer("Wrangler Doe", new Address("114 Imagined Circle", "Whereon", "TX 77001", "USA"));
        Customer customer3 = new Customer("Elkington Masst", new Address("798 Unred Boulevard", "Satisfied", "Toronto", "Canada"));

        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);
        Order order3 = new Order(customer3);

        order1.AddProduct(product4);
        order1.AddProduct(product9);
        order1.AddProduct(product2);
        order2.AddProduct(product7);
        order2.AddProduct(product1);
        order2.AddProduct(product5);
        order3.AddProduct(product8);
        order3.AddProduct(product6);
        order3.AddProduct(product3);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order1.GetTotalCost().ToString("0.00"));
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order2.GetTotalCost().ToString("0.00"));
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order3.GetTotalCost().ToString("0.00"));
        Console.WriteLine();

    }
}