namespace Matrix.Tests
{
    [TestClass]
    public class MatrixTests
    {
        [TestMethod]
        public void CheckMatrixTrace()
        {
            // Arrange 
            int matrixTrace;
            int[,] filledMatrix = { { 1, 2, 3 }, { 4, 5, 0 } };
            Matrix matrix = new Matrix(2,3);

            // Act
            matrixTrace = matrix.GetMatrixTrace(filledMatrix);

            //Assert
            Assert.AreEqual(6, matrixTrace);
        }

        [TestMethod]
        public void CheckSquareMatrixTrace()
        {
            // Arrange
            int matrixTrace;
            int[,] filledMatrix = { { 1, 2, 3 }, { 4, 5, 10 }, { 100, 22, 23 } };
            Matrix matrix = new Matrix(3,3);

            // Act
            matrixTrace = matrix.GetMatrixTrace(filledMatrix);

            //Assert
            Assert.AreEqual(29, matrixTrace);
        }

        [TestMethod]
        public void CheckEmptyMatrixTrace()
        {
            // Arrange
            int matrixTrace;
            int[,] filledMatrix = { { }, { } };
            Matrix matrix = new Matrix(1,2);

            // Act
            matrixTrace = matrix.GetMatrixTrace(filledMatrix);

            //Assert
            Assert.AreEqual(0, matrixTrace);
        }

        [TestMethod]
        public void CheckOnNull()
        {
            // Arrange
            int[,] currentMatrix = null;
            Matrix matrix = new Matrix(2,2);

            //Act & Assert
            Assert.ThrowsException<NullReferenceException>(() => matrix.GetMatrixTrace(currentMatrix));
        }

        [TestMethod]
        public void CheckBoundaryValues()
        {
            // Arrange
            int matrixTrace;
            int[,] filledMatrix = { { 0, 1, 31, 2 }, { 2, -1, 32, 3 }, { 33, 3, 100, 4 }, { 34, 4, 34, 101 } };
            Matrix matrix = new Matrix(4, 4);

            // Act
            matrixTrace = matrix.GetMatrixTrace(filledMatrix);

            //Assert
            Assert.AreEqual(200, matrixTrace);
        }

        [TestMethod]
        public void CheckNotNumericValues()
        {
            // Arrange
            int matrixTrace;
            int[,] filledMatrix = { { '?', 'w' }, { '7', ')' } };
            Matrix matrix = new Matrix(2,2);

            // Act
            matrixTrace = matrix.GetMatrixTrace(filledMatrix);

            //Assert
            //as symbols have converted in codepoints
            Assert.AreEqual(104, matrixTrace);
        }

        [TestMethod]
        public void CheckMoreThanThousandEntries()
        {
            // Arrange
            int matrixTrace;
            int[,] currentMatrix = new int[50, 51];
            Matrix matrix = new Matrix(50,51);

            // Act
            matrix.FillMatrix(currentMatrix, 0, 100);
            matrixTrace = matrix.GetMatrixTrace(currentMatrix);

            //Assert
            Assert.IsNotNull(matrixTrace);
        }
    }
}