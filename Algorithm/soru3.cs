namespace Algorithm
{
    public class soru3
    {
        public static void Algoritma()
        {
            double toplam = 0;
            for (int i = 1; i <= 10; i++)
            {
                toplam += Math.Pow(i, 3);
            }

            Console.WriteLine(toplam);

        }

    }
}
