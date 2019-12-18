using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.CSharp.Array
{
    class ContainsDuplicate
    {
        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> unique = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (unique.Contains(nums[i]))
                {
                    return true;
                }
                else
                {
                    unique.Add(nums[i]);
                }
            }

            return false;
        }
    }
}
