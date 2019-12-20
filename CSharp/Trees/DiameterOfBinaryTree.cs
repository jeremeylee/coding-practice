using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.CSharp.Trees
{
    class DiameterOfBinaryTree
    {
        public int DiameterOfBinaryTree(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            int height = TreeHeight(root.left) + TreeHeight(root.right);
            return Math.Max(height, Math.Max(DiameterOfBinaryTree(root.left), DiameterOfBinaryTree(root.right)));
        }

        public int TreeHeight(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            return Math.Max(TreeHeight(root.left), TreeHeight(root.right)) + 1;
        }
    }
}
