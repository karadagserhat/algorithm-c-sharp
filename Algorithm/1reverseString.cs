namespace Algorithm
{
    public class reverseString
    {
        public static void Algoritma1(string str)
        {

            Console.WriteLine(str.Reverse().ToArray());

        }

        public static void Algoritma2(string str)
        {
            string sonuc = "";

            foreach (var ch in str)
            {
                sonuc = ch + sonuc;
            }

            Console.WriteLine(sonuc);

        }

    }
}
