namespace Algorithm
{
    public class soru7
    {
        public static void Algoritma()
        {
            int sayi1 = int.Parse(Console.ReadLine());
            int sayi2 = int.Parse(Console.ReadLine());

            int sonuc = 0;
            //while (sayi1 - sayi2 >= 0)
            //{
            //    sayi1 = sayi1 - sayi2;
            //    sonuc++;
            //}

            int _sayi1 = sayi1;

            for (int i = 0; i < _sayi1; i++)
            {
                sayi1 -= sayi2;
                sonuc++;

                if (sayi1 < sayi2) break;
            }

            Console.WriteLine(sonuc);
        }

    }
}
