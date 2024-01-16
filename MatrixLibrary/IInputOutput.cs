namespace Matrix
{
    public interface IInputOutput
    {
        int GetUserDimension(string dimensionName);
        void OutputArray(MatrixClass matrix);
        void Output(string title, string message);
    }
}
