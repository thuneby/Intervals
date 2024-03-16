using Intervals.Core.Models;
using Intervals.Core.Functions;



namespace Intervals.Core.Tests.Functions
{
    public class ArithmeticTests
    {
        private readonly Arithmetic _arithmetic;

        public ArithmeticTests() 
        {
            _arithmetic = new Arithmetic();
        }

        [Fact]
        public void AddBothPositive()
        {
            // Arrange
            var i1 = new Interval(1, 2);
            var i2 = new Interval(1, 2);

            // Act
            var result = _arithmetic.ISum(i1, i2);

            // Assert
            Assert.Equal(2, result.Lower);
            Assert.Equal(4, result.Upper);
        }

        [Fact]
        public void AddPositiveNegative()
        {
            // Arrange
            var i1 = new Interval(1, 2);
            var i2 = new Interval(-2, -1);

            // Act
            var result = _arithmetic.ISum(i1, i2);

            // Assert
            Assert.Equal(-1, result.Lower);
            Assert.Equal(1, result.Upper);
        }


    }
}
