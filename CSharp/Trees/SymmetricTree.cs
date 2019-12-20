using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.CSharp.Trees
{
    class SymmetricTree
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }
            return helper(root.left, root.right);
        }

        public bool helper(TreeNode left, TreeNode right)
        {
            if ((left == null && right != null) || left != null && right == null)
            {
                return false;
            }
            if (left == null && right == null)
            {
                return true;
            }
            if (left.val != right.val)
            {
                return false;
            }

            return helper(left.left, right.right) && helper(left.right, right.left);
        }
    }
}
