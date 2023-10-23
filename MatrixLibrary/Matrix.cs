namespace MatrixLibrary
{
    public class Matrix
    {
        //Users input matrix dimensions into the program(columns and lines).
        public int[,] GetDimensions()
        {
            Console.WriteLine("Enter the number of columns, integer: ");
            int firstDimension = int.Parse(Console.ReadLine());
            //check on number
            // boundary values
            Console.WriteLine("Enter the number of lines, integer: ");
            int secondDimension = int.Parse(Console.ReadLine());
            int[,] dimensionsArray = new int[firstDimension, secondDimension];
            return dimensionsArray;
        }

        //Program fill matrix with random numbers (from 0 till 100 included).
        public void FillMatrix(int[,] arrayToFill)
        {
            int max = 100;
            int min = 0;
            Random random = new Random();

            for (int i = 0; i < arrayToFill.GetLength(0); i++)
            {
                for (int j = 0; j < arrayToFill.GetLength(1); j++)
                {
                    arrayToFill[i, j] = random.Next(min, max);
                    Console.WriteLine(arrayToFill[i, j]);
                }
            }


        }

        //            Program should find a matrix trace.

        //Matrix trace is the sum of all elements on the main diagonal.

        //Main diagonal of the square matrix is the diagonal which starts in the top left corner and finishes in the bottom right corner.

        //Main diagonal for a rectangle matrix is the line, which starts in the top left corner and moves right and down, till the border(bottom or right) of the matrix.


        public int GetMatrixTrace(int[,] matrixArray)
        {
            int numberOfLines = matrixArray.GetLength(0);
            int numberOfRows = matrixArray.GetLength(1);
            int sum = 0;
            Console.Write("Principal Diagonal: ");

            for (int i = 0; i < numberOfLines; i++)
            {
                for (int j = 0; j < numberOfRows; j++)
                {
                    if (i == j)
                    {
                        sum += matrixArray[i, j];

                        Console.Write(matrixArray[i, j] + ", ");
                    }
                }
            }
            Console.WriteLine("");
            Console.WriteLine($"Sum of main diagonal: {0}",sum);
            //Check sum calculation!
            return sum;
        }
    }
}
