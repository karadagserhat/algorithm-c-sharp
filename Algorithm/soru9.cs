namespace Algorithm
{
    public class soru9
    {
        public static void Algoritma()
        {
            int sayi1 = int.Parse(Console.ReadLine());


            if (Basamak(sayi1))
            {
                int _sayi1 = sayi1;
                double toplam = 0;
                while (true)
                {
                    int basamak = sayi1 % 10;
                    sayi1 /= 10;

                    toplam += Math.Pow(basamak, 3);

                    if (sayi1 < 10)
                    {
                        basamak = sayi1;
                        toplam += Math.Pow(basamak, 3);
                        break;
                    }
                }

                if (toplam == _sayi1) Console.WriteLine("Esit");
                else Console.WriteLine("Degil");
            }
            else
            {
                Console.WriteLine("Yanlisss");
            }

        }

        static bool Basamak(int sayi)
        {
            int sonuc = 1;

            while (true)
            {
                sonuc++;
                sayi /= 10;

                if (sayi < 10) break;
            }

            return sonuc == 3;
        }

    }
}
