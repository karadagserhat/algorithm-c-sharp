namespace Algorithm
{
    public class SolutionContainsDuplicate
    {
        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> seen = [];

            foreach (int n in nums)
            {
                if (!seen.Add(n)) return true;
            }

            return false;
        }
    }
}
