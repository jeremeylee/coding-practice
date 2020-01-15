using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.CSharp.Trees
{
    class LevelOrderTraversal
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {


            List<IList<int>> output = new List<IList<int>>();
            Queue<TreeNode> currNode = new Queue<TreeNode>();

            if (root == null)
            {
                return output;
            }

            currNode.Enqueue(root);

            while (currNode.Count != 0)
            {
                int level = currNode.Count;
                List<int> sub = new List<int>();
                for (int i = 0; i < level; i++)
                {
                    if (currNode.Peek().left != null)
                    {
                        currNode.Enqueue(currNode.Peek().left);
                    }

                    if (currNode.Peek().right != null)
                    {
                        currNode.Enqueue(currNode.Peek().right);
                    }
                    sub.Add(currNode.Dequeue().val);
                }
                output.Add(sub);
            }

            return output;
        }

        public IList<IList<int>> LevelOrderRecurse(TreeNode root)
        {
            List<IList<int>> output = new List<IList<int>>();
            helper(output, root, 0);
            return output;
        }

        public void helper(IList<IList<int>> output, TreeNode root, int height)
        {
            if (root == null)
            {
                return;
            }

            if (height >= output.Count)
            {
                output.Add(new List<int>());
            }

            output[height].Add(root.val);
            helper(output, root.left, height + 1);
            helper(output, root.right, height + 1);
            return;
        }
    }
}
