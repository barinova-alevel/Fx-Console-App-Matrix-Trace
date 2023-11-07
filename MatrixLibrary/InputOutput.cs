namespace MatrixLibrary
{
    public class InputOutput
    {
        public int[,] GetDimensions()
        {
            int firstDimension;
            int secondDimension;
            string usersNumberLines;
            string usersNumberColumn;

            Console.WriteLine("Enter the number of lines, positive integer: ");
            usersNumberLines = Console.ReadLine();
            firstDimension = CheckNumber(usersNumberLines);

            Console.WriteLine("Enter the number of columns, positive integer: ");
            usersNumberColumn = Console.ReadLine();

            secondDimension = CheckNumber(usersNumberColumn);

            int[,] dimensionsArray = new int[firstDimension, secondDimension];
            return dimensionsArray;
        }

        public void OutputArray(int[,] matrix)
        {
            Console.Clear();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(matrix[i, j] + "\t");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(matrix[i, j] + "\t");
                    }
                }
                Console.WriteLine();
            }
        }

        public void PrintSnailShellOrderMatrix(int[,] matrix)

        {
            int lineStart = 0;
            int lineEnd = matrix.GetLength(0) - 1;
            int columnStart = 0;
            int columnEnd = matrix.GetLength(1) - 1;
            Console.WriteLine("Matrix in snail shell order: ");

            while (columnStart <= columnEnd && lineStart <= lineEnd)
            {
                for (int i = columnStart; i < columnEnd; i++)
                    Console.Write($"{matrix[lineStart, i]} ");

                for (int i = lineStart; i < lineEnd; i++)
                    Console.Write($"{matrix[i, columnEnd]} ");

                for (int i = columnEnd; i > columnStart; i--)
                    Console.Write($"{matrix[lineEnd, i]} ");

                for (int i = lineEnd; i > lineStart; i--)
                    Console.Write($"{matrix[i, columnStart]} ");

                lineStart++;
                columnEnd--;
                lineEnd--;
                columnStart++;
            }
        }

        private static int CheckNumber(string userInput)
        {
            int dimension;
            while (!int.TryParse(userInput, out dimension) || (dimension<=0))
            {
                Console.WriteLine("Wrong input, must be a positive integer. Try again:");
                string newInput = Console.ReadLine();
                if (!(newInput == null))
                {
                    userInput = newInput;
                }
                else
                {
                    Console.WriteLine("Wrong input, press any key to exit");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }
            return dimension;
        }
    }
}
