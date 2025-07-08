public class StandardStrategy : IPackagingStrategy
{
    public string GetPackaging(IProduct product)
    {
        return "Standard Box";
    }
}
