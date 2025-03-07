namespace Algorithm
{
    public class pyramids
    {
        public static void Algoritma1(int n)
        {

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new string(' ', n - i) + new string('#', i * 2 - 1) + new string(' ', n - i));
            }

        }
    }
}
