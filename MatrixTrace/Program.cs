using System.Net.Http.Headers;
using MatrixLibrary;

class Program
{
    public const int MaxMatrixEntry = 100;
    public const int MinMatrixEntry = 0;
    static void Main(string[] args)
    {
        var inputOutput = new InputOutput();
        int[,] initMatrix;
        int[,] filledMatrix;

        initMatrix = Matrix.CreateMatrix();

        var matrix = new Matrix(initMatrix.GetLength(0), initMatrix.GetLength(1));
        filledMatrix = matrix.FillMatrix(initMatrix, MinMatrixEntry, MaxMatrixEntry);
        inputOutput.OutputArray(filledMatrix);
        inputOutput.OutputMatrixTrace(matrix.GetMatrixTrace(filledMatrix));
        inputOutput.OutputSnailShellMatrixOrder(filledMatrix);

        Console.ReadKey();
    }
}

//check unit tests
//These tests are for Matrix class, co name them MatrixTests