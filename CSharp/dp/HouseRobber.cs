using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.CSharp.dp
{
    class HouseRobber
    {
        public int Rob(int[] nums)
        {
            if (nums.Length <= 1)
            {
                return nums.Length == 1 ? nums[0] : 0;
            }
            int[] dp = new int[nums.Length];

            dp[0] = nums[0];
            dp[1] = Math.Max(dp[0], nums[1]);

            for (int i = 2; i < nums.Length; i++)
            {
                dp[i] = Math.Max(dp[i - 1], nums[i] + dp[i - 2]);
            }

            return dp[dp.Length - 1];
        }
    }
}
