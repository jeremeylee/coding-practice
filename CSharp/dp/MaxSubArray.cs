using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.CSharp.dp
{
    class MaxSubArray
    {
        public int MaxSubArray(int[] nums)
        {
            int max = nums[0];
            int currMax = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                currMax = Math.Max(currMax + nums[i], nums[i]);
                max = Math.Max(max, currMax);
            }
            return max;
        }
    }
}
