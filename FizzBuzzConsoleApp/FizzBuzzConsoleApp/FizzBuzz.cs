using System;
namespace MathsTask
{
    public class FizzBuzz
    {
        public List<string> execute(int x)
        {
            var output = new List<string>();
            for (int y = 1; y <= x; y++)
            {
                if (divisibleBy3(y))
                {
                    if (divisibleBy5(y))
                    {
                        output.Add("FizzBuzz");
                    }
                    else
                    {
                        output.Add("Fizz");
                    }
                }
                else
                {
                    if (divisibleBy5(y))
                    {
                        output.Add("Buzz");
                    }
                    else
                    {
                        output.Add(y.ToString());
                    }
                }
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
