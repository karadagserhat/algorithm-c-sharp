namespace Algorithm
{
    public class maxChar
    {
        public static char Algoritma1(string str)
        {
            int max = 0;
            char maxChar = '\0';

            var charMap = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (charMap.ContainsKey(c)) charMap[c]++;
                else charMap[c] = 1;
            }

            foreach (var entry in charMap)
            {
                if (entry.Value > max)
                {
                    max = entry.Value;
                    maxChar = entry.Key;
                }
            }

            return maxChar;

        }
    }
}
