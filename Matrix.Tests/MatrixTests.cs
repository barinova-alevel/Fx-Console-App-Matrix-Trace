using Moq;

namespace Matrix.Tests
{
    //Для генерації випадкових чисел потрібно створити окремий провайдер.Він буде реалізовувати інтерфейс в якому буде метод, повертає рандомні значення.Потім в конструкторі класу матриці потрібно буде передавати інстанс цього генератора і викликати його метод, щоб отримати рандомне значення. Коли переходимо до тестів, то тут ми можемо  використати один з фреймворків для створення Mock-об'єктів уже в самому тесті. Можеш погуглити про mock в unit тестах. Якщо нічого не знайдеш, або не розберешся, я можу дати декілька посилань на популярні ////бібліотеки.

    [TestClass]
    public class MatrixTests
    {
        public const int MaxMatrixEntry = 100;
        public const int MinMatrixEntry = 0;

        [TestMethod]
        public void CheckMatrixTrace()
        {
            //Arrange
            // Created implementation of INumberProvider for test purposes
            INumberProvider numberProvider = new TestNumberProvider();
            MatrixClass matrix = new MatrixClass(3, 5, numberProvider);
            int result;

            //Act
            result = matrix.GetMatrixTrace(matrix);

            //Assert
            Assert.AreEqual(21, result);

            //Attempt to perform test with mock object:
            // Arrange
            var moqNumberGenerator = new Mock<INumberProvider>();
            int resultForMoq;

            //according to this logic, all matrix entries are 10
            //10 10 10
            //10 10 10
            moqNumberGenerator.Setup(number => number.GetNumber(MinMatrixEntry, MaxMatrixEntry)).Returns(10);
            var matrix1 = new MatrixClass(2, 3, moqNumberGenerator.Object);

            // Act
            resultForMoq = matrix1.GetMatrixTrace(matrix1);

            //Assert
            Assert.AreEqual(20, resultForMoq);
        }

        [TestMethod]
        public void CheckSquareMatrixTrace()
        {
            //Arrange
            INumberProvider numberProvider = new TestNumberProvider();
            MatrixClass matrix = new MatrixClass(2, 2, numberProvider);
            int result;

            //Act
            result = matrix.GetMatrixTrace(matrix);

            //Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void CheckEmptyMatrixTrace()
        {
            //Arrange
            INumberProvider numberProvider = new TestNumberProvider();
            MatrixClass matrix = new MatrixClass(0, 0, numberProvider);
            int result;

            //Act
            result = matrix.GetMatrixTrace(matrix);

            //Assert
            Assert.AreEqual(0, result);
        }

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
