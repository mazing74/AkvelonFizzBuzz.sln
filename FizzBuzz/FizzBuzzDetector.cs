using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    enum WordType
    {
        normal,
        Fizz,
        Buzz,
        FizzBuzz,
        
    }
    public class FizzBuzzDetector
    {
        public FizzBuzzResult getOverlappings(string input)
        {
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
        private string[] SplitIntoWords(string input)
        {
        }
        private WordType DetermineWordType(int index)
        {
        }
        private FizzBuzzResult BuildResult()
        {
        }
    }
}
