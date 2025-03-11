namespace Algorithm
{
    public class fib
    {
        public static int Algoritma1(int n)
        {
            if (n < 2) return n;

            int[] results = new int[n + 1];
            results[0] = 0;
            results[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                results[i] = results[i - 1] + results[i - 2];
            }

            return results[n];

        }

        public static int Algoritma2(int n)
        {
            if (n < 2) return n;

            return Algoritma2(n - 1) + Algoritma2(n - 2);

        }

        static Dictionary<int, int> cache = [];

        public static int Algoritma3(int n)
        {
            if (cache.ContainsKey(n)) return cache[n];
            if (n < 2) return n;

            cache[n] = Algoritma3(n - 1) + Algoritma3(n - 2);
            return cache[n];

        }
    }
}
