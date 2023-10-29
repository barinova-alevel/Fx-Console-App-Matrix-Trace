namespace MatrixLibrary
{
    public class Matrix
    {
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
