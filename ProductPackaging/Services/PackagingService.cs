public class PackagingService
{
    public string PackProduct(IProduct product)
    {
        IPackagingStrategy strategy = product switch
        {
            Book => new StandardStrategy(),
            Glass => new FragileStrategy(),
            Laptop => new ElectronicStrategy(),
            _ => throw new NotSupportedException("Unknown product")
        };

        return strategy.GetPackaging(product);
    }
}
