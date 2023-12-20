namespace Matrix
{
    public class RandomNumberProvider : IRandomNumberProvider
    {
        private Random random;

        public RandomNumberProvider()
        {
            random = new Random();
        }

        public int GetNumber(int Min, int Max)
        {
            return random.Next(Min, Max + 1);
        }
    }
}

