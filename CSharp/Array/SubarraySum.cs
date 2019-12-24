using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.CSharp.Array
{
    class SubarraySum
    {
        //Unoptimized
        public int SubarraySum(int[] nums, int k)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int sum = 0;
                for (int j = i; j < nums.Length; j++)
                {
                    sum += nums[j];
                    if (sum == k)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        //optimized
        public int SubarraySumMap(int[] nums, int k)
        {
            int count = 0;
            int sum = 0;
            Dictionary<int, int> preSum = new Dictionary<int, int>();
            preSum.Add(0, 1);

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (preSum.ContainsKey(sum - k))
                {
                    count += preSum[sum - k];
                }
                if (preSum.ContainsKey(sum))
                {
                    preSum[sum]++;
                }
                else
                {
                    preSum.Add(sum, 1);
                }


            }
            return count;
        }
    }
}
