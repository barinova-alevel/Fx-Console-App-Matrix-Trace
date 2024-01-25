using Moq;

namespace Matrix.nUnitTests
{
    [TestFixture]
    public class Tests
    {
        public const int MaxMatrixEntry = 100;
        public const int MinMatrixEntry = 0;

        [TestCase(new[] { 5, 2, 52, 99, 100, 98 }, 105)]
        [TestCase(new[] { 0, 1, 52, 99, 72, 99 }, 72)]
        [TestCase(new[] { 100, 2, 52, 99, 5, 03 }, 105)]
        [TestCase(new[] { -1, 2, 52, 99, 1, 101 }, 0)]
        public void CheckMatrixTrace(int[] entries, int expected)
        {
            // Arrange
            var moqNumberGenerator = new Mock<INumberProvider>();
            int position = -1;
            Func<int, int, int> number = (min, max) => { position++; return entries[position]; };
            moqNumberGenerator.Setup(numberProvider => numberProvider.GetNumber(It.IsAny<int>(), It.IsAny<int>())).Returns(number);
            var matrix1 = new MatrixClass(2, 3, moqNumberGenerator.Object);

            // Act
            var actualMatrixTrace = matrix1.GetMatrixTrace(matrix1);

            //Assert
            Assert.That(actualMatrixTrace, Is.EqualTo(expected));
            Console.WriteLine($"Actual Result: {actualMatrixTrace}, Expected Result: {expected}");
        }

        [TestCase(new[] { 0, 1, 52, 99, 100, 101 }, 2, 3, "0 1 52 101 100 99 ")]
        [TestCase(new[] { 82, 87, 24, 47, 59, 42, 42, 11, 78, 78, 53, 14, 42, 54, 82, 16, 85, 100, 32, 8, 24, 63, 60, 26, 38, 4, 97, 70, 20, 77, 0, 93, 59, 71, 81, 97, 84, 17, 46, 36, 16, 15, 31, 9, 31, 58, 42, 45, 28, 44, 85, 11, 16, 66, 4, 23, 73, 54, 95, 82, 3, 15, 7, 0, 81, 59, 1, 70, 3, 71, 1 }, 10, 7, "82 87 24 47 59 42 42 54 24 70 81 15 28 23 7 71 3 70 1 59 81 0 73 44 31 97 20 63 82 11 78 78 53 14 42 8 97 71 16 45 4 15 3 82 95 54 85 9 84 77 60 16 85 100 32 4 59 36 42 66 16 11 31 17 0 26 38 93 46 58 "), Description("Test of SnailShellPass for 10X7 matrix as bigger then ordinary one")]
        public void CheckSnailShellPath(int[] entries, int lines, int columns, string expected)
        {
            // Arrange
            var moqNumberGenerator = new Mock<INumberProvider>();
            int position = -1;
            Func<int, int, int> number = (min, max) => { position++; return entries[position]; };
            moqNumberGenerator.Setup(numberProvider => numberProvider.GetNumber(It.IsAny<int>(), It.IsAny<int>())).Returns(number);
            var matrix1 = new MatrixClass(lines, columns, moqNumberGenerator.Object);

            // Act
            var snailShellPath = matrix1.SnailShellPath(matrix1);

            //Assert
            Assert.That(snailShellPath, Is.EqualTo(expected));
            Console.WriteLine($"Actual Result: {snailShellPath}, Expected Result: {expected}");
        }

        [Test]
        public void CheckThrowingNullReferenceException()
        {
            // Arrange
            var moqNumberGenerator = new Mock<INumberProvider>();
            moqNumberGenerator = null;

            // Act & Assert
            Assert.Throws<NullReferenceException>(() => new MatrixClass(1, 1, moqNumberGenerator.Object));
        }

        [Test]
        public void CheckThrowingOverflowException()
        {
            // Arrange
            var moqNumberGenerator = new Mock<INumberProvider>();
            Func<int, int, int> number = (min, max) => { return 1; };
            moqNumberGenerator.Setup(numberProvider => numberProvider.GetNumber(It.IsAny<int>(), It.IsAny<int>())).Returns(number);

            //Act & Assert
            Assert.Throws<OverflowException>(() => new MatrixClass(-1, 0, moqNumberGenerator.Object));
        }
    }
}