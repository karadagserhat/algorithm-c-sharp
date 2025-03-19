﻿namespace Algorithm
{
    public class SolutionCountPrimes
    {
        public int CountPrimes(int n)
        {
            if (n < 2) return 0;

            bool[] isPrime = new bool[n];
            Array.Fill(isPrime, true);

            isPrime[0] = isPrime[1] = false;

            for (int i = 2; i * i < n; i++)
            {
                if (isPrime[i])
                {
                    for (int j = i * i; j < n; j += i)
                    {
                        isPrime[j] = false;
                    }
                }
            }

            return isPrime.Count(x => x);



        }
    }
}
