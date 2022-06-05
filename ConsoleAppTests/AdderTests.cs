using ConsoleApp;
using Xunit;

namespace ConsoleAppTests
{
    public class AdderTests
    {
        [Fact]
        public void Add()
        {
            Assert.Equal(5, Adder.Add(2, 3));
        }
    }
}