using System.Runtime.CompilerServices;

namespace MatrixLibrary
{
    public class Matrix
    {
        private int[,] initMatrix { get; set; }
        public int Lines;
        public int Columns;

        public Matrix(int lines, int columns)
        {
            Lines = lines;
            Columns = columns;
            initMatrix = new int[lines, columns];
        }

        public int this[int line, int column]
        {
            get => initMatrix[line - 1, column - 1];
            set => initMatrix[line - 1, column - 1] = value;
        }

        public int[,] FillMatrix(int[,] arrayToFill)
        {
            int max = 100;
            int min = 0;
            Random random = new Random();

            for (int i = 0; i < arrayToFill.GetLength(0); i++)
            {
                for (int j = 0; j < arrayToFill.GetLength(1); j++)
                {
                    arrayToFill[i, j] = random.Next(min, max);
                }
            }
            return arrayToFill;
        }

        public int GetMatrixTrace(int[,] matrixArray)
        {
            int numberOfLines = matrixArray.GetLength(0);
            int numberOfRows = matrixArray.GetLength(1);
            int matrixTrace = 0;

            for (int i = 0; i < numberOfLines; i++)
            {
                for (int j = 0; j < numberOfRows; j++)
                {
                    if (i == j)
                    {
                        matrixTrace += matrixArray[i, j];
                    }
                }
            }
            Console.WriteLine("");
            Console.WriteLine($"Matrix trace: {matrixTrace}");
            return matrixTrace;
        }
    }
}
