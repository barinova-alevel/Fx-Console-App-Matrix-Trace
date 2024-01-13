using Moq;

namespace Matrix.nUnitTests
{
    [TestFixture]
    public class Tests
    {
        public const int MaxMatrixEntry = 100;
        public const int MinMatrixEntry = 0;
        
        [TestCase(new[] { 0, 1, 52, 99, 100, 101 }, 100)] 
        [TestCase(new[] { 5, 2, 52, 99, 100, 101 }, 105)] 
        [TestCase(new[] { -1, 2, 52, 99, 1, 101 }, 0)] 
        [TestCase(new[] { 101, 2, 52, 99, 5, 101 }, 106)]

        public void CheckMatrixTrace(int[] entries, int expected)
        {
            // Arrange
            var moqNumberGenerator = new Mock<INumberProvider>();
            int position = -1;
            
            Func<int, int, int> number = (min,max) =>  { position++; return entries[position]; };
            moqNumberGenerator.Setup(numberProvider => numberProvider.GetNumber(It.IsAny<int>(), It.IsAny<int>())).Returns(number);

            var matrix1 = new MatrixClass(2, 3, moqNumberGenerator.Object);

            // Act
            var actualMatrixTrace = matrix1.GetMatrixTrace(matrix1);

            //Assert
            Assert.That(actualMatrixTrace, Is.EqualTo(expected));
            Console.WriteLine($"Actual Result: {actualMatrixTrace}, Expected Result: {expected}");
        }
    }
}