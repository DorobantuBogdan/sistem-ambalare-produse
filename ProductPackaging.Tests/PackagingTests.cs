using Xunit;
using ProductPackaging.Services;
using ProductPackaging.Products;

namespace ProductPackaging.Tests
{
    public class PackagingTests
    {
        [Fact]
        public void Book_Should_Use_StandardPackaging()
        {
            var service = new PackagingService();
            var result = service.PackProduct(new Book());
            Assert.Equal("Standard Box", result);
        }

        [Fact]
        public void Glass_Should_Use_FragilePackaging()
        {
            var service = new PackagingService();
            var result = service.PackProduct(new Glass());
            Assert.Equal("Fragile Bubble Wrap", result);
        }
    }
}
