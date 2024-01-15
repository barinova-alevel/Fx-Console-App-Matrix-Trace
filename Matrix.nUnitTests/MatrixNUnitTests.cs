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

            Func<int, int, int> number = (min, max) => { position++; return entries[position]; };
            moqNumberGenerator.Setup(numberProvider => numberProvider.GetNumber(It.IsAny<int>(), It.IsAny<int>())).Returns(number);

            var matrix1 = new MatrixClass(2, 3, moqNumberGenerator.Object);

            // Act
            var actualMatrixTrace = matrix1.GetMatrixTrace(matrix1);

            //Assert
            Assert.That(actualMatrixTrace, Is.EqualTo(expected));
            Console.WriteLine($"Actual Result: {actualMatrixTrace}, Expected Result: {expected}");
        }

        [TestCase(new[] { 0, 1, 52, 99, 100, 101 }, "0 1 52 101 100 99 ")]
                public void CheckSnailShellPath_2x3(int[] entries, string expected)
        {
            // Arrange
            var moqNumberGenerator = new Mock<INumberProvider>();
            int position = -1;

            Func<int, int, int> number = (min, max) => { position++; return entries[position]; };
            moqNumberGenerator.Setup(numberProvider => numberProvider.GetNumber(It.IsAny<int>(), It.IsAny<int>())).Returns(number);

            var matrix1 = new MatrixClass(2, 3, moqNumberGenerator.Object);

            // Act
            var snailShellPath = matrix1.SnailShellPath(matrix1);

            //Assert
            Assert.That(snailShellPath, Is.EqualTo(expected));
            Console.WriteLine($"Actual Result: {snailShellPath}, Expected Result: {expected}");
        }

        [TestCase(new[] { 82, 87, 24, 47, 59, 42, 42, 11, 78, 78, 53, 14, 42, 54, 82, 16, 85, 100, 32, 8, 24, 63, 60, 26, 38, 4, 97, 70, 20, 77, 0, 93, 59, 71, 81, 97, 84, 17, 46, 36, 16, 15, 31, 9, 31, 58, 42, 45, 28, 44, 85, 11, 16, 66, 4, 23, 73, 54, 95, 82, 3, 15, 7, 0, 81, 59, 1, 70, 3, 71, 1 }, "82 87 24 47 59 42 42 54 24 70 81 15 28 23 7 71 3 70 1 59 81 0 73 44 31 97 20 63 82 11 78 78 53 14 42 8 97 71 16 45 4 15 3 82 95 54 85 9 84 77 60 16 85 100 32 4 59 36 42 66 16 11 31 17 0 26 38 93 46 58 ")]

        public void CheckSnailShellPath_10x7(int[] entries, string expected)
        {
            // Arrange
            var moqNumberGenerator = new Mock<INumberProvider>();
            int position = -1;

            Func<int, int, int> number = (min, max) =>
            {
                position++;
                return entries[position];
            };
            moqNumberGenerator.Setup(numberProvider => numberProvider.GetNumber(It.IsAny<int>(), It.IsAny<int>())).Returns(number);

            var matrix1 = new MatrixClass(10, 7, moqNumberGenerator.Object);

            // Act
            var snailShellPath = matrix1.SnailShellPath(matrix1);

            //Assert
            Assert.That(snailShellPath, Is.EqualTo(expected));
            Console.WriteLine($"Actual Result: {snailShellPath} \nExpected Result: {expected}");
        }

        /*[Test]
        public void CheckThrowingException()
        {
            // Arrange
            var moqNumberGenerator = new Mock<INumberProvider>();
            moqNumberGenerator.Setup(numberProvider => numberProvider.GetNumber(It.IsAny<int>(), It.IsAny<int>())).Throws(new IndexOutOfRangeException("Error message"));
            var matrix1 = new MatrixClass(-1, 3, moqNumberGenerator.Object);

            // Act & Assert
            Assert.Throws<IndexOutOfRangeException>(() => matrix1.GetMatrixTrace(matrix1));
        } */

        /*[Test]
        public void CheckOnNull()
        {
            //Arrange
           var matrix1 = new MatrixClass(1, 3, null);

            //Act & Assert
            Assert.Throws<NullReferenceException>(() => matrix1.GetMatrixTrace(matrix1));
        } */
    }
}