namespace Algorithm
{
    public class anagram
    {
        public static bool Algoritma1(string str1, string str2)
        {
            var str1Map = CharMap(str1);
            var str2Map = CharMap(str2);

            if (str1Map.Count != str2Map.Count) return false;

            foreach (var kvp in str1Map)
            {
                if (!str2Map.TryGetValue(kvp.Key, out int count) || count != kvp.Value) return false;
            }


            return true;
        }

        static Dictionary<char, int> CharMap(string str)
        {
            var map = new Dictionary<char, int>();

            foreach (char c in str.ToLower().Where(char.IsLetterOrDigit))
            {
                if (map.TryGetValue(c, out int value)) map[c] = ++value;
                else map[c] = 1;
            }

            return map;
        }

        public static bool Algoritma2(string str1, string str2)
        {
            return CleanString(str1) == CleanString(str2);
        }

        static string CleanString(string str)
        {
            return new string(str
                .ToLower()
                .Where(char.IsLetterOrDigit)
                .OrderBy(c => c)
                .ToArray());
        }
    }
}
