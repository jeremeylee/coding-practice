using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.CSharp.Array
{
    class TwoSum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> complements = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (complements.ContainsKey(complement))
                {
                    return new int[] { complements[complement], i };
                }
                else
                {
                    complements[nums[i]] = i;
                }
            }

            return null;
        }
    }
}
