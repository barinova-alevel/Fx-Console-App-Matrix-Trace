using Moq;

namespace Matrix.Tests
{
    //Для генерації випадкових чисел потрібно створити окремий провайдер.Він буде реалізовувати інтерфейс в якому буде метод, повертає рандомні значення.Потім в конструкторі класу матриці потрібно буде передавати інстанс цього генератора і викликати його метод, щоб отримати рандомне значення. Коли переходимо до тестів, то тут ми можемо  використати один з фреймворків для створення Mock-об'єктів уже в самому тесті. Можеш погуглити про mock в unit тестах. Якщо нічого не знайдеш, або не розберешся, я можу дати декілька посилань на популярні ////бібліотеки.

    [TestClass]
    public static class MatrixTests
    {
        public const int MaxMatrixEntry = 100;
        public const int MinMatrixEntry = 0;

       // [TestMethod]
        
        //public static void CheckMatrixTrace()
        //{
        //    // Arrange 
        //    int matrixTrace;
        //    var testMatrix = new Mock<MatrixClass>();
           
        //    int[,] filledMatrix = { { 1, 2, 3 }, { 4, 5, 0 } };
        //    MatrixClass matrix = new MatrixClass(2, 3);

        //    // Act
        //    matrixTrace = matrix.GetMatrixTrace(matrix);

        //    //Assert
        //    Assert.AreEqual(6, matrixTrace);
        //}

        //[TestMethod]
        //public void CheckSquareMatrixTrace()
        //{
        //    // Arrange
        //    int matrixTrace;
        //    int[,] filledMatrix = { { 1, 2, 3 }, { 4, 5, 10 }, { 100, 22, 23 } };
        //    MatrixClass matrix = new MatrixClass(3,3);

        //    // Act
        //    matrixTrace = matrix.GetMatrixTrace(filledMatrix);

        //    //Assert
        //    Assert.AreEqual(29, matrixTrace);
        //}

        //[TestMethod]
        //public void CheckEmptyMatrixTrace()
        //{
        //    // Arrange
        //    int matrixTrace;
        //    int[,] filledMatrix = { { }, { } };
        //    MatrixClass matrix = new MatrixClass(1,2);

        //    // Act
        //    matrixTrace = matrix.GetMatrixTrace(filledMatrix);

        //    //Assert
        //    Assert.AreEqual(0, matrixTrace);
        //}

        //[TestMethod]
        //public void CheckOnNull()
        //{
        //    // Arrange
        //    int[,] currentMatrix = null;
        //    MatrixClass matrix = new MatrixClass(2,2);

        //    //Act & Assert
        //    Assert.ThrowsException<NullReferenceException>(() => matrix.GetMatrixTrace(currentMatrix));
        //}

        //[TestMethod]
        //public void CheckBoundaryValues()
        //{
        //    // Arrange
        //    int matrixTrace;
        //    int[,] filledMatrix = { { 0, 1, 31, 2 }, { 2, -1, 32, 3 }, { 33, 3, 100, 4 }, { 34, 4, 34, 101 } };
        //    MatrixClass matrix = new MatrixClass(4, 4);

        //    // Act
        //    matrixTrace = matrix.GetMatrixTrace(filledMatrix);

        //    //Assert
        //    Assert.AreEqual(200, matrixTrace);
        //}

        //[TestMethod]
        //public void CheckNotNumericValues()
        //{
        //    // Arrange
        //    int matrixTrace;
        //    int[,] filledMatrix = { { '?', 'w' }, { '7', ')' } };
        //    MatrixClass matrix = new MatrixClass(2,2);

        //    // Act
        //    matrixTrace = matrix.GetMatrixTrace(filledMatrix);

        //    //Assert
        //    //as symbols have converted in codepoints
        //    Assert.AreEqual(104, matrixTrace);
        //}

        //[TestMethod]
        //public void CheckMoreThanThousandEntries()
        //{
        //    // Arrange
        //    int matrixTrace;
        //    int[,] currentMatrix = new int[50, 51];
        //    MatrixClass matrix = new MatrixClass(50,51);

        //    // Act
        //    matrix.FillMatrix(0, 100);
        //    matrixTrace = matrix.GetMatrixTrace(currentMatrix);

        //    //Assert
        //    Assert.IsNotNull(matrixTrace);
        //}
    }
}