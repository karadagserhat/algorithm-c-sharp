namespace Algorithm
{
    public class soru8
    {
        public static void Algoritma()
        {
            int sayi1 = int.Parse(Console.ReadLine());

            int sonuc = 1;

            while (true)
            {


                if (sayi1 < 10) break;

                sayi1 /= 10;
                sonuc++;
            }


            Console.WriteLine(sonuc);
        }

    }
}
