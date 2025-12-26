public class BestTimeToBuyAndSellStockSolution
{
public int MaxProfit(int[] prices)
    {
        int minPrice = int.MaxValue;
        int maxProfit = 0;

        for (int i = 0; i < prices.Length; i++)
        {
            if (prices[i] < minPrice)
            {
                minPrice = prices[i]; // buy here
            }
            else
            {
                int profit = prices[i] - minPrice; // sell here
                maxProfit = Math.Max(maxProfit, profit);
            }
        }

        return maxProfit;
    }
}