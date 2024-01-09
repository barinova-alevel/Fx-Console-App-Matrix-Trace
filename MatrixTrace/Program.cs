using Matrix;

class Programs
{
    public const int MaxMatrixEntry = 100;
    public const int MinMatrixEntry = 0;
    static void Main()
    {
        while (true)
        {
            var inputOutput = new InputOutput();
            int firstDimension;
            int secondDimension;
            
            Console.WriteLine("Do you want to generate new matrix? (yes/no): ");
            string userInput = Console.ReadLine().ToLower();

            if (userInput == "no")
            {
                Environment.Exit(1);
            }
            else if (userInput != "yes")
            {
                Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
            }
            else if(userInput == "yes") 
            {
            firstDimension = inputOutput.GetUserDimension("line");
            secondDimension = inputOutput.GetUserDimension("column");
            INumberProvider number = new RandomNumberProvider();

            var matrix = new MatrixClass(firstDimension, secondDimension, number);

            inputOutput.OutputArray(matrix);
            inputOutput.Output("Matrix trace", matrix.GetMatrixTrace(matrix).ToString());
            inputOutput.Output("Matrix in snail shell order", matrix.SnailShellPath(matrix));
            }
        }
    }
}
//Look through the project
//error in unit tests: System.Collections.Generic.KeyNotFoundException: Unable to find UniqueTest VSTestAdapter
//Check for Other Test Adapters:
