namespace Algorithm
{
    public class Solution5
    {
        public bool IsPalindrome(string s)
        {
            string filtered = CleanString(s);

            int left = 0;
            int right = filtered.Length - 1;

            while (left < right)
            {
                if (filtered[left] != filtered[right]) return false;

                left++;
                right--;
            }

            return true;
        }

        private string CleanString(string s)
        {
            string result = "";

            foreach (char c in s)
            {
                if (char.IsLetterOrDigit(c)) result += char.ToLower(c);
            }

            return result;
        }
    }

}
