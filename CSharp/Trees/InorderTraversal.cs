using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.CSharp.Trees
{
    class InorderTraversal
    {
        //Recursive
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

        //Iterative
        public IList<int> InorderTraversal(TreeNode root)
        {
            List<int> inorder = new List<int>();
            Stack<TreeNode> stack = new Stack<TreeNode>();

            if (root == null)
            {
                return inorder;
            }

            while (true)
            {
                while (root != null)
                {
                    stack.Push(root);
                    root = root.left;
                }

                if (stack.Count == 0)
                {
                    break;
                }

                root = stack.Pop();
                inorder.Add(root.val);
                root = root.right;

            }

            return inorder;

        }
    }
}
