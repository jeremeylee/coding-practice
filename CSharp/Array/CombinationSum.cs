using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.CSharp.Array
{
    class CombinationSum
    {
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            List<IList<int>> res = new List<IList<int>>();
            helper(res, new List<int>(), candidates, 0, target, 0);
            return res;
        }

        public void helper(IList<IList<int>> res, IList<int> temp, int[] candidates, int sum, int target, int index)
        {
            if (sum == target)
            {
                res.Add(new List<int>(temp));
                return;
            }
            else if (sum > target)
            {
                return;
            }

            for (int i = index; i < candidates.Length; i++)
            {
                temp.Add(candidates[i]);
                helper(res, temp, candidates, sum + candidates[i], target, i);
                temp.RemoveAt(temp.Count - 1);
            }
        }
    }
}
