using System;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;


namespace MatrixLibrary
{
    public class Matrix
    {
        //Users input matrix dimensions into the program(columns and lines).
        
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
                }
            }
        }

        //            Program should find a matrix trace.

        //Matrix trace is the sum of all elements on the main diagonal.

        //Main diagonal of the square matrix is the diagonal which starts in the top left corner and finishes in the bottom right corner.

        //Main diagonal for a rectangle matrix is the line, which starts in the top left corner and moves right and down, till the border(bottom or right) of the matrix.
        
        // ? Do I have to implement square matrix trace if rectangle matrix has already done? => check Length(0) and Length(1)


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

        //Program should print the filled matrix into the console.Main diagonal should be highlighted.
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
