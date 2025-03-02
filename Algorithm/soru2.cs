namespace Algorithm
{
    public class soru2
    {
        public static void Algoritma()
        {
            try
            {
                Console.WriteLine("Sayi gir 1");
                int s1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Sayi gir 2");
                int s2 = int.Parse(Console.ReadLine());

                Console.WriteLine(s1 * s1 + s2 * s2);
            }
            catch
            {
                Console.WriteLine("Dogru deger gir");
            }

        }

    }
}
