using System;
using System.Text;

namespace MathsTask
{
    public class FizzBuzz
    {
        public List<string> execute(int x)
        {
            var output = new List<string>();
            var builder = new StringBuilder();

            for (int y = 1; y <= x; y++)
            {
                if (divisibleBy3(y))
                {
                    builder.Append("Fizz");
                }
                if (divisibleBy5(y))
                {
                    builder.Append("Buzz");
                }

                if(builder.Length == 0)
                {
                    builder.Append(y);
                }

                output.Add(builder.ToString());
                builder.Clear();
            }

            return output;
        }

        private bool divisibleBy3(int y)
        {
            return y % 3 == 0;
        }

        private bool divisibleBy5(int y)
        {
            return y % 5 == 0;
        }
    }
}
