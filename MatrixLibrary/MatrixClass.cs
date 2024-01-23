using System.Text;
namespace Matrix
{
    public class MatrixClass
    {
        const int Min = 0;
        const int Max = 100;
        private int[,] _initMatrix;
        public int Lines { get; private set; }
        public int Columns { get; private set; }
        public MatrixClass(int lines, int columns, INumberProvider numberGenerator)
        {
            Lines = lines;
            Columns = columns;

            _initMatrix = new int[Lines, Columns];

            for (int i = 0; i < Lines; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    _initMatrix[i, j] = numberGenerator.GetNumber(Min, Max + 1);
                }
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
            int passedLineUp = -1;
            int passedColumnStart = -1;
            int passedColumnEnd = matrix.Columns;
            int passedLineDown = matrix.Lines;

            StringBuilder snailShell = new StringBuilder();

            while (columnStart <= columnEnd && lineStart <= lineEnd)
            {
                for (int i = columnStart; i < columnEnd; i++)
                {
                    snailShell.AppendFormat("{0} ", matrix[lineStart, i]);
                }
                passedLineUp++;

                for (int i = lineStart; i < lineEnd; i++)
                {
                    snailShell.AppendFormat("{0} ", matrix[i, columnEnd]);
                }
                passedColumnEnd--;

                if (passedLineDown == lineEnd || passedLineUp == lineEnd)
                {
                    snailShell.AppendFormat("{0} ", matrix[lineEnd, columnEnd]);
                    break;
                }
                for (int i = columnEnd; i > columnStart; i--)
                {
                    snailShell.AppendFormat("{0} ", matrix[lineEnd, i]);
                }
                passedLineDown--;

                if (passedColumnStart == columnStart || passedColumnEnd == columnStart)
                {
                    snailShell.AppendFormat("{0} ", matrix[lineEnd, columnStart]);
                    break;
                }
                for (int i = lineEnd; i > lineStart; i--)
                {
                    snailShell.AppendFormat("{0} ", matrix[i, columnStart]);
                }
                passedColumnStart++;

                lineStart++;
                columnEnd--;
                lineEnd--;
                columnStart++;
            }
            return snailShell.ToString();
        }
    }
}