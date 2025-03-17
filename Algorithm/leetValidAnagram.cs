namespace Algorithm
{
    public class Solution4
    {
        public bool IsAnagram(string s, string t)
        {
            // Uzunluklar eşit değilse anagram olamaz
            if (s.Length != t.Length) return false;

            // Karakterleri sıralayıp karşılaştırma yöntemi
            return s.OrderBy(c => c).SequenceEqual(t.OrderBy(c => c));
        }


        public bool IsAnagram2(string s, string t)
        {
            return CleanString(s) == CleanString(t);
        }

        public string CleanString(string str)
        {
            return new string(str
                .ToLower()
                .Where(char.IsLetterOrDigit)
                .OrderBy(c => c)
                .ToArray());
        }
    }

}
