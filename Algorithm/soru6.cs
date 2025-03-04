namespace Algorithm
{
    public class soru6
    {
        public static void Algoritma()
        {
            int sayi1 = int.Parse(Console.ReadLine());
            int sayi2 = int.Parse(Console.ReadLine());

            int sonuc = 0;
            for (int i = 0; i < sayi2; i++)
            {
                sonuc += sayi1;
            }

            Console.WriteLine(sonuc);
        }

    }
}
