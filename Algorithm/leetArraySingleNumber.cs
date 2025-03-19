namespace Algorithm
{
    public class SolutionSingleNumber
    {
        public int SingleNumber(int[] nums)
        {
            HashSet<int> seen = [];

            foreach (int n in nums)
            {
                if (!seen.Add(n))
                {
                    seen.Remove(n);
                }
            }

            return seen.First();
        }
    }
}
