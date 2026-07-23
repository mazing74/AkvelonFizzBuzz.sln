namespace FizzBuzz
{
    public class FizzBuzzResult
    {
        public int Count { get;  }
        public string Output { get; }

        public FizzBuzzResult(string output ,int count)
        {
            Count = count;
            Output = output;
        }

    }
}
