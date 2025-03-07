namespace Algorithm
{
    public class steps
    {
        public static void Algoritma1(int n)
        {

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new string('#', i) + new string(' ', n - i));
            }

        }

        public static void Algoritma2(int n)
        {

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new string('#', i).PadRight(n));
            }
        }

        public static void Algoritma3(int n)
        {

            for (int row = 0; row < n; row++)
            {
                string stair = "";
                for (int col = 0; col < n; col++)
                {
                    if (col <= row) stair += "#";
                    else stair += " ";
                }

                Console.WriteLine(stair);
            }
        }

    }
}
