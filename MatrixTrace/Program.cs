using System.ComponentModel.Design;
using Matrix;

class Programs
{
    public const int MaxMatrixEntry = 100;
    public const int MinMatrixEntry = 0;
    static void Main(string[] args)
    {
        var inputOutput = new InputOutput();
        int firstDimension;
        int secondDimension;
        firstDimension = inputOutput.GetUserDimension("line");
        secondDimension = inputOutput.GetUserDimension("column");

        var matrix = new MatrixClass(firstDimension, secondDimension);

        inputOutput.OutputArray(matrix);
        inputOutput.Output("Matrix trace", matrix.GetMatrixTrace(matrix).ToString());
        inputOutput.Output("Matrix in snail shell order", matrix.SnailShellPath(matrix));

        Console.ReadKey();
    }
}
//Unit tests
//Check snail shell order with 1 line, 3x5
