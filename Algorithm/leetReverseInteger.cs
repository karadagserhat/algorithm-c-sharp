﻿namespace Algorithm
{
    public class Solution1
    {
        public int Reverse(int x)
        {
            int result = 0;



            while (x != 0)
            {
                int digit = x % 10;
                x /= 10;

                if (result > int.MaxValue / 10)
                    return 0;
                if (result < int.MinValue / 10)
                    return 0;

                result = result * 10 + digit;
            }

            return result;
        }
    }

}
