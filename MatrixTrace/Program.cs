using System.Net.Http.Headers;
using MatrixLibrary;

class Program
{
    static void Main(string[] args)
    {
        var inputOutput = new InputOutput();
        int[,] initMatrix;
        int[,] filledMatrix;

        initMatrix = Matrix.CreateMatrix();

        var matrix = new Matrix(initMatrix.GetLength(0), initMatrix.GetLength(1));
        filledMatrix = matrix.FillMatrix(initMatrix);
        inputOutput.OutputArray(filledMatrix);
        matrix.GetMatrixTrace(filledMatrix);

        Console.WriteLine("Matrix in snail shell order: ");
        Console.WriteLine(matrix.SnailShellPath(filledMatrix));

        Console.ReadKey();
    }
}