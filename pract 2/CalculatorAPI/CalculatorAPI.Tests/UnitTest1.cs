using Xunit;
using CalculatorTesting;

namespace CalculatorAPI.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void AddTest()
        {
            var c = new CalculatorService();
            Assert.Equal(10, c.Add(5, 5));
        }

        [Fact]
        public void SubtractTest()
        {
            var c = new CalculatorService();
            Assert.Equal(5, c.Subtract(10, 5));
        }

        [Fact]
        public void MultiplyTest()
        {
            var c = new CalculatorService();
            Assert.Equal(25, c.Multiply(5, 5));
        }

        [Fact]
        public void DivideTest()
        {
            var c = new CalculatorService();
            Assert.Equal(5, c.Divide(10, 2));
        }
    }
}