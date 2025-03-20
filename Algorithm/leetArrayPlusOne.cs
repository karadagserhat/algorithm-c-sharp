namespace Algorithm
{
    public class SolutionPlusOne
    {
        public int[] PlusOne(int[] digits)
        {
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }
                digits[i] = 0;
            }

            // Eğer döngü bitmişse, tüm basamaklar 9'dur, bu durumda dizinin başına 1 eklememiz gerekir
            int[] result = new int[digits.Length + 1];
            result[0] = 1;
            return result;
        }
    }
}
