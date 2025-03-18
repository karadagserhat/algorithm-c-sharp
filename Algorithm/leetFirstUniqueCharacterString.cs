namespace Algorithm
{
    public class Solution3
    {
        public int FirstUniqChar(string s)
        {
            Dictionary<char, int> charMap = [];

            foreach (char c in s)
            {
                if (charMap.TryGetValue(c, out int value)) charMap[c] = ++value;
                else charMap[c] = 1;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (charMap[s[i]] == 1) return i;
            }

            return -1;

        }
    }

}
