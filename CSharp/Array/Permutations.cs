using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.CSharp.Array
{
    class Permutations
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            IList<IList<int>> list = new List<IList<int>>();
            helper(nums, new List<int>(), list);
            return list;
        }

        public void helper(int[] nums, List<int> curr, IList<IList<int>> list)
        {
            if (curr.Count == nums.Length)
            {
                list.Add(curr.ToArray());

            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (curr.Contains(nums[i]))
                {
                    continue;
                }

                curr.Add(nums[i]);
                helper(nums, curr, list);
                curr.RemoveAt(curr.Count - 1);
            }

        }
    }
}
