namespace Matrix
{
    public class TestNumberProvider : INumberProvider
    {
        private int expected;
        public int GetNumber(int Min, int Max)
        {
            return expected += 1;
        }

    }
}
