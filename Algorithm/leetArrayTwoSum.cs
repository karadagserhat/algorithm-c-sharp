namespace Algorithm
{
    public class SolutionTwoSum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dict = [];

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                if (dict.TryGetValue(complement, out int value)) return [value, i];

                dict[nums[i]] = i;
            }

            return [];
        }
    }
}
