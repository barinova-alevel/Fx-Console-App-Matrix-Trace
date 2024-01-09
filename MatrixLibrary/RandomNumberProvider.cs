namespace Matrix
{
    public class RandomNumberProvider : INumberProvider
    {
        private Random _random;

        public RandomNumberProvider()
        {
            _random = new Random();
        }

        public int GetNumber(int Min, int Max)
        {
            return _random.Next(Min, Max + 1);
        }
    }
}

