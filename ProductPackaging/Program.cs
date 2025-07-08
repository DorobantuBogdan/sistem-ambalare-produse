using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter product type (Book / Glass / Laptop): ");
        string input = Console.ReadLine();

        try
        {
            var factory = new ProductFactory();
            var product = factory.CreateProduct(input);

            var service = new PackagingService();
            string packaging = service.PackProduct(product);

            Console.WriteLine($"Product: {product.Name}");
            Console.WriteLine($"Packaging: {packaging}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
