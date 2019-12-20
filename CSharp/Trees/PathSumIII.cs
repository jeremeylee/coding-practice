using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.CSharp.Trees
{
    class PathSumIII
    {
        public int PathSum(TreeNode root, int sum)
        {
            if (root == null)
            {
                return 0;
            }

            int count = helper(root, sum);
            return PathSum(root.left, sum) + PathSum(root.right, sum) + count;
        }

        public int helper(TreeNode root, int sum)
        {
            if (root == null)
            {
                return 0;
            }
            int count = 0;
            if (root.val == sum)
            {
                count++;
            }

            return count + helper(root.left, sum - root.val) + helper(root.right, sum - root.val);
        }
    }
}
