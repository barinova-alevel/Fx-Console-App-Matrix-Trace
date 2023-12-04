using System;

namespace Matrix
{
    internal interface IRandomNumberProvider
    {
        int GetRandomNumber(int Min, int Max);
    }
}
