namespace Algorithm
{
    public class soru5
    {
        public static void Algoritma()
        {
            int sayi = int.Parse(Console.ReadLine());

            int sonuc = 1;
            for (int i = sayi; i > 0; i--)
            {
                sonuc *= i;
            }

            Console.WriteLine(sonuc);
        }

    }
}
