public class ElectronicStrategy : IPackagingStrategy
{
    public string GetPackaging(IProduct product)
    {
        return "Anti-static Foam";
    }
}
