using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.CSharp.Array
{
    class FindDisappearedNumbers
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            int[] count = new int[nums.Length + 1];
            List<int> res = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                count[nums[i]]++;
            }

            for (int i = 1; i < count.Length; i++)
            {
                if (count[i] == 0)
                {
                    res.Add(i);
                }
            }

            return res;
        }
    }
}
