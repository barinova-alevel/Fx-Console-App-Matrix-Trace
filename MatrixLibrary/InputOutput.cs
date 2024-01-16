namespace Matrix
{
    public class InputOutput : IInputOutput
    {
        public int GetUserDimension(string dimensionName)
        {
            int dimension;
            string userInput;

            Console.WriteLine($"Enter the number of {dimensionName}s, positive integer: ");
            userInput = Console.ReadLine();
            dimension = CheckNumber(userInput);
            return dimension;
        }
        
        public void OutputArray(MatrixClass matrix)
        {
            Console.Clear();
            for (int i = 0; i < matrix.Lines; i++)
            {
                for (int j = 0; j < matrix.Columns; j++)
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

        public void Output(string title, string message)
        {
            Console.WriteLine($"{title}: {message}");
        }
       
        private static int CheckNumber(string userInput)
        {
            int dimension;
            while (!int.TryParse(userInput, out dimension) || (dimension <= 0))
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
