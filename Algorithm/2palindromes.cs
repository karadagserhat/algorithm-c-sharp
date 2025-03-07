namespace Algorithm
{
    public class palindromes
    {
        public static bool Algoritma1(string str)
        {

            return str == new string(str.Reverse().ToArray());

        }

        public static bool Algoritma2(string str)
        {

            for (var i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - 1 - i]) return false;
            }

            return true;

        }

    }
}
