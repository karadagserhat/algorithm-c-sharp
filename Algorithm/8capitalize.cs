namespace Algorithm
{
    public class capitalize
    {
        public static string Algoritma1(string str)
        {
            string[] words = str.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = Char.ToUpper(words[i][0]) + words[i].Substring(1);
            }

            return string.Join(" ", words);
        }

        public static string Algoritma2(string str)
        {
            string result = Char.ToUpper(str[0]).ToString();

            for (int i = 1; i < str.Length; i++)
            {
                if (str[i - 1] == ' ') result += Char.ToUpper(str[i]);
                else result += str[i];
            }

            return result;
        }

    }
}
