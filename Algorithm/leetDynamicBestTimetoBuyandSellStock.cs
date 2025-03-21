namespace Algorithm
{
    public class SolutionMaxProfit
    {
        public int MaxProfit(int[] prices)
        {
            if (prices.Length == 0) return 0;

            int minPrice = int.MaxValue;
            int maxProfit = 0;

            foreach (int price in prices)
            {
                if (price < minPrice) minPrice = price;
                else
                {
                    int PotentialProfit = price - minPrice;
                    maxProfit = Math.Max(maxProfit, PotentialProfit);
                }
            }

            return maxProfit;
        }
    }
}
