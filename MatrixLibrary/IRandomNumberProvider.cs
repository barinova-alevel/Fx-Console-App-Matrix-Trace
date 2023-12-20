using System;

namespace Matrix
{
    public interface IRandomNumberProvider
    {
        int GetNumber(int Min, int Max);
    }
}
