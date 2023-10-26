using MatrixLibrary;

class Program
{
    static void Main(string[] args)
    {
        Matrix matrix = new Matrix();
        int[,] currentMatrix = matrix.GetDimensions();
        matrix.FillMatrix(currentMatrix);
        matrix.OutputArray(currentMatrix);
        matrix.GetMatrixTrace(currentMatrix);

        Console.ReadKey();
    }
}