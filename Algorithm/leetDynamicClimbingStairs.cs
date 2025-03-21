namespace Algorithm
{
    public class SolutionClimbStairs
    {
        public int ClimbStairs(int n)
        {
            if (n < 0) return 0;
            if (n == 1) return 1;
            if (n == 2) return 2;

            int oneStepBefore = 2;
            int twoStepBefore = 1;
            int allWays = 0;

            for (int i = 3; i <= n; i++)
            {
                allWays = oneStepBefore + twoStepBefore;
                twoStepBefore = oneStepBefore;
                oneStepBefore = allWays;
            }

            return allWays;

        }
    }
}
