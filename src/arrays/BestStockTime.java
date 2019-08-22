package arrays;

public class BestStockTime {
    public int maxProfitBruteForce(int[] prices) {
        if (prices.length < 2) {
            return 0;
        }

        int maxProfit = 0;
        for (int i = 0; i < prices.length; i++) {
            for(int j = i + 1; j < prices.length; j++) {
                if (prices[j] - prices[i] > maxProfit) {
                    maxProfit = prices[j] - prices[i];
                }
            }
        }

        if (maxProfit > 0) {
            return maxProfit;
        } else {
            return 0;
        }

    }
}
