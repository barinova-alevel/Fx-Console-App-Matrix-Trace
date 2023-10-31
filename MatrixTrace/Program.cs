using MatrixLibrary;

class Program
{
    static void Main(string[] args)
    {
        var matrix = new Matrix();
        var inputOutput = new InputOutput();
        int[,] initMatrix;
        int[,] filledMatrix;

        initMatrix = inputOutput.GetDimensions();
        filledMatrix = matrix.FillMatrix(initMatrix);
        inputOutput.OutputArray(filledMatrix);
        matrix.GetMatrixTrace(filledMatrix);
        inputOutput.PrintSnailShellOrderMatrix(filledMatrix);

        Console.ReadKey();
    }
}