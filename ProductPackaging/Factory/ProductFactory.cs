public class ProductFactory
{
    public IProduct CreateProduct(string productType)
    {
        switch (productType.ToLower())
        {
            case "book": return new Book();
            case "glass": return new Glass();
            case "laptop": return new Laptop();
            default: throw new ArgumentException("Unknown product type");
        }
    }
}
