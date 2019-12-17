using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.CSharp.dp
{
    class CoinChange
    {
        public int CoinChange(int[] coins, int amount)
        {
            int[] dp = new int[amount + 1];

            for (int i = 0; i < dp.Length; i++)
            {
                dp[i] = amount + 1;
            }

            dp[0] = 0;
            for (int i = 0; i < coins.Length; i++)
            {
                for (int j = 1; j <= amount; j++)
                {
                    if (coins[i] <= j)
                    {
                        dp[j] = Math.Min(dp[j - coins[i]] + 1, dp[j]);
                    }
                }
            }
            Console.Write(dp[dp.Length - 1]);
            return dp[dp.Length - 1] > amount ? -1 : dp[dp.Length - 1];
        }
    }
}
