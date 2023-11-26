using System.Text;

namespace Matrix
{
    public class MatrixClass
    {
        const int Min = 0;
        const int Max = 100;
        private int[,] _initMatrix;

        public int Lines { get; }
        public int Columns { get; }

        public MatrixClass(int lines, int columns)
        {
            Lines = lines;
            Columns = columns;
            _initMatrix = new int[Lines, Columns];

            Random random = new Random();
            if (Lines > 0 && Columns > 0)
            {
                for (int i = 0; i < Lines; i++)
                {
                    for (int j = 0; j < Columns; j++)
                    {
                        _initMatrix[i, j] = random.Next(Min, Max + 1);
                    }
                }
            }
            else
            {
                //What will happen, if lines or columns will be 0?
            }
        }
        public int this[int line, int column]
        {
            get { return _initMatrix[line, column]; }
            private set { _initMatrix[line, column] = value; }
        }

        public int GetMatrixTrace(MatrixClass matrixArray)
        {
            int numberOfLines = matrixArray.Lines;
            int numberOfRows = matrixArray.Columns;
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
            return matrixTrace;
        }

        public string SnailShellPath(MatrixClass matrix)
        {
            int lineStart = 0;
            int lineEnd = matrix.Lines - 1;
            int columnStart = 0;
            int columnEnd = matrix.Columns - 1;

            StringBuilder snailShell = new StringBuilder();

            while (columnStart <= columnEnd && lineStart <= lineEnd)
            {
                for (int i = columnStart; i < columnEnd; i++)
                    snailShell.AppendFormat("{0} ", matrix[lineStart, i]);

                for (int i = lineStart; i < lineEnd; i++)
                    snailShell.AppendFormat("{0} ", matrix[i, columnEnd]);

                for (int i = columnEnd; i > columnStart; i--)
                    snailShell.AppendFormat("{0} ", matrix[lineEnd, i]);

                for (int i = lineEnd; i > lineStart; i--)
                    snailShell.AppendFormat("{0} ", matrix[i, columnStart]);

                lineStart++;
                columnEnd--;
                lineEnd--;
                columnStart++;
            }
            return snailShell.ToString();
        }
    }
}
