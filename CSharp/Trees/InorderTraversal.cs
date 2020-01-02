using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.CSharp.Trees
{
    class InorderTraversal
    {
        public List<int> inorder = new List<int>();

        public IList<int> InorderTraversal(TreeNode root)
        {
            if (root == null)
            {
                return inorder;
            }

            InorderTraversal(root.left);
            inorder.Add(root.val);
            InorderTraversal(root.right);
            return inorder;
        }
    }
}
