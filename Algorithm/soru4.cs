namespace Algorithm
{
    public class soru4
    {
        public static void Algoritma()
        {
            Console.WriteLine("Dogum tarihi");
            DateTime yas = DateTime.Parse(Console.ReadLine()!);

            TimeSpan sonuc = DateTime.Now - yas;

            Console.WriteLine(sonuc.Days / 365);
        }

    }
}
