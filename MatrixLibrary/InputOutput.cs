namespace MatrixLibrary
{
    public class InputOutput
    {
        public int[,] GetDimensions()
        {
            Console.WriteLine("Enter the number of lines, integer: ");
            string usersNumberLines = Console.ReadLine();
            int firstDimension = CheckNumber(usersNumberLines);

            Console.WriteLine("Enter the number of columns, integer: ");
            string usersNumberColumn = Console.ReadLine();
            int secondDimension = CheckNumber(usersNumberColumn);

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

        private int CheckNumber(string userInput)
        {
            int dimension;
            if (int.TryParse(userInput, out dimension))
            { }
            else
            {
                Console.WriteLine("Wrong input, press any key to exit");
                Console.ReadKey();
                Environment.Exit(0);
            }
            return dimension;
        }
    }
}
