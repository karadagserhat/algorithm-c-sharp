namespace Algorithm
{
    public class soru1ikiSayininToplami
    {
        public static void Algoritma()
        {
            try
            {
                Console.WriteLine("1.sayi");
                int sayi1 = int.Parse(Console.ReadLine());
                Console.WriteLine("2.sayi");
                int sayi2 = int.Parse(Console.ReadLine());

                Console.WriteLine(sayi1 + sayi2);
            }
            catch
            {
                Console.WriteLine("Dogru deger gir");
            }

        }

    }
}
