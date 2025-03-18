﻿namespace Algorithm
{
    public class SolutionFizzBuzz
    {
        public IList<string> FizzBuzz(int n)
        {
            IList<string> arr = [];

            for (int i = 1; i <= n; i++)
            {
                if (i % 15 == 0) arr.Add("FizzBuzz");
                else if (i % 3 == 0) arr.Add("Fizz");
                else if (i % 5 == 0) arr.Add("Buzz");
                else arr.Add(i.ToString());
            }

            return arr;
        }
    }

}
