using System.Text;

namespace FizzBuzz
{
    enum WordType
    {
        Normal,
        Fizz,
        Buzz,
        FizzBuzz,

    }
    public class FizzBuzzDetector
    {
        public FizzBuzzResult getOverlappings(string input)
        {
            ValidateInput(input);

            var words = Tokenize(input);

            string output = ReplaceWords(input, words);

            return BuildResult(output);

        }


        private void ValidateInput(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentException("Input cannot be null or empty.", "input");
            }
            if (!(input.Length <= 100 && input.Length >= 7))
            {
                throw new ArgumentException("Input must be between 7 and 100 characters long.", "input");
            }
        }

        private List<WordToken> Tokenize(string input)
        {
            List<WordToken> words = new();

            int wordIndex = 0;

            int i = 0;

            while (i < input.Length)
            {
                if (char.IsLetterOrDigit(input[i]))
                {
                    int start = i;
                    StringBuilder word = new();

                    while (i < input.Length)
                    {
                        char c = input[i];

                        if (char.IsLetterOrDigit(c))
                        {
                            word.Append(c);
                            i++;
                        }
                        else if (c == '\'' && i + 1 < input.Length && char.IsLetterOrDigit(input[i + 1]))
                        {
                            word.Append(c);
                            i++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    wordIndex++;

                    words.Add(new WordToken(word.ToString(), wordIndex, start, i - start));
                }
                else
                {
                    i++;
                }
            }

            return words;
        }
        private WordType DetermineWordType(int wordNumber)
        {
            bool fizz = wordNumber % 3 == 0;
            bool buzz = wordNumber % 5 == 0;

            if (fizz && buzz)
                return WordType.FizzBuzz;

            if (fizz)
                return WordType.Fizz;

            if (buzz)
                return WordType.Buzz;

            return WordType.Normal;
        }
        private string ReplaceWords(string input, List<WordToken> words)
        {
            StringBuilder result = new(input);

            for (int i = words.Count - 1; i >= 0; i--)
            {
                var word = words[i];

                WordType? replacement = DetermineWordType(word.Index);

                if (replacement == WordType.Normal)
                    continue;

                result.Remove(word.Start, word.Length);
                result.Insert(word.Start, replacement.ToString());
            }

            return result.ToString();
        }
        private FizzBuzzResult BuildResult(string output)
        {
            int count = 0;
            var words = Tokenize(output);

            foreach (var word in words)
            {
                if (word.Word == "Fizz" ||
                    word.Word == "Buzz" ||
                    word.Word == "FizzBuzz")
                {
                    count++;
                }
            }

            return new FizzBuzzResult(output, count);
          
        }
    }
}
