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
    }
}
