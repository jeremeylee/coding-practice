using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.CSharp.Array
{
    class MinSubArray
    {
        public int MinSubArrayLen(int s, int[] nums)
        {
            int smallest = Int32.MaxValue;
            int start = 0;
            int end = 0;
            int sum = 0;

            while (start < nums.Length)
            {
                sum += nums[end];
                if (sum >= s)
                {
                    smallest = Math.Min(end - start + 1, smallest);
                    sum = 0;
                    start++;
                    end = start;
                    continue;
                }
                end++;
                if (end > nums.Length - 1)
                {
                    sum = 0;
                    start++;
                    end = start;
                }
            }

            return smallest == Int32.MaxValue ? 0 : smallest;
        }
    }
}
