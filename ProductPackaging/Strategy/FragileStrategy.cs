public class FragileStrategy : IPackagingStrategy
{
    public string GetPackaging(IProduct product)
    {
        return "Fragile Bubble Wrap";
    }
}
