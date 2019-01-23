using Xunit;

namespace RerunTests
{
    public class Class1
    {
        [Fact]
        public void Fail() => Assert.True(false, "Failed test");
    }
}
