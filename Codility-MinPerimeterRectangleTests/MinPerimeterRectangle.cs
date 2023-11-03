using Codility_MinPerimeterRectangle;

namespace Codility_MinPerimeterRectangleTests
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(30, 22)] // Example test case
        [InlineData(1, 4)]   // Smallest N
        [InlineData(100, 40)] // N is a perfect square
        [InlineData(31, 64)]  // N is prime
        [InlineData(1000000000, 126500)] // Largest N
        public void Solution_Returns_Minimal_Perimeter(int N, int expectedPerimeter)
        {
            // Arrange
            var solution = new Solution();

            // Act
            int result = solution.solution(N);

            // Assert
            Assert.Equal(expectedPerimeter, result);
        }

        [Theory]
        [InlineData(0)] // N is below the lowest range
        [InlineData(1000000001)] // N is above the highest range
        public void Solution_Returns_MaxIntValue_For_OutOfRange_N(int N)
        {
            // Arrange
            var solution = new Solution();

            // Act
            int result = solution.solution(N);

            // Assert
            Assert.Equal(int.MaxValue, result);
        }
    }
}