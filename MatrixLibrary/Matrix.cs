using System.Runtime.CompilerServices;
using System.Text;

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

        public static int[,] CreateMatrix()
        {
            int firstDimension;
            int secondDimension;

            firstDimension = InputOutput.GetUserDimension("line");
            secondDimension = InputOutput.GetUserDimension("column");

            int[,] dimensionsArray = new int[firstDimension, secondDimension];
            return dimensionsArray;
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

        public string SnailShellPath(int[,] matrix)
        {
            int lineStart = 0;
            int lineEnd = matrix.GetLength(0) - 1;
            int columnStart = 0;
            int columnEnd = matrix.GetLength(1) - 1;

            StringBuilder snailShell = new StringBuilder();

            while (columnStart <= columnEnd && lineStart <= lineEnd)
            {
                //Check bounds
                //Check the algorithm
                for (int i = columnStart; i < columnEnd; i++)
                    snailShell.Append(matrix[i, columnStart] + " ");

                for (int i = lineStart; i < lineEnd; i++)
                    snailShell.Append(matrix[i, columnStart] + " ");

                for (int i = columnEnd; i > columnStart; i--)
                    snailShell.Append(matrix[i, columnStart]);

                for (int i = lineEnd; i > lineStart; i--)
                    snailShell.Append(matrix[i, columnStart]);

                lineStart++;
                columnEnd--;
                lineEnd--;
                columnStart++;
            }
            return snailShell.ToString();
        }
    }
}
