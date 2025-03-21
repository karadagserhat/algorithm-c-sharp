namespace Algorithm
{
    public class SolutionMaxSubArray
    {
        public int MaxSubArray(int[] nums)
        {
            int maxSum = int.MinValue;
            int currentSum = 0;

            foreach (int num in nums)
            {
                currentSum += num;
                maxSum = Math.Max(maxSum, currentSum);

                if (currentSum < 0) currentSum = 0;
            }

            return maxSum;
        }
    }
}
