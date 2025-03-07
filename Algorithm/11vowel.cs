using System.Text.RegularExpressions;

namespace Algorithm
{
    public class vowel
    {
        public static void Algoritma1(string str)
        {
            int count = 0;
            string vowels = "aeoui";

            foreach (char c in str)
            {
                if (vowels.Contains(c)) count++;
            }

            Console.WriteLine(count);

        }

        public static void Algoritma2(string str)
        {
            Console.WriteLine(Regex.Matches(str, "[aeuio]", RegexOptions.IgnoreCase).Count);

        }
    }
}
