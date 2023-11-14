using System.Text;

namespace MatrixLibrary
{
    public class InputOutput
    {
        public static int GetUserDimension(string dimensionName)
        {
            int dimension;
            string userInput;

            Console.WriteLine($"Enter the number of {dimensionName}s, positive integer: ");
            userInput = Console.ReadLine();
            dimension = CheckNumber(userInput);
            return dimension;
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

        public void OutputSnailShellMatrixOrder(int[,] filledMatrix)
        {
            Console.WriteLine("Matrix in snail shell order: ");
            Console.WriteLine(Matrix.SnailShellPath(filledMatrix));
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
