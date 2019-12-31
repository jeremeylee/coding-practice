using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.CSharp.Graph
{
    class CloneGraph
    {
        /*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node(){}
    public Node(int _val,IList<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
}
*/
        public class Solution
        {
            public Node CloneGraph(Node node)
            {
                if (node == null)
                {
                    return null;
                }

                Dictionary<Node, Node> map = new Dictionary<Node, Node>();
                Queue<Node> visited = new Queue<Node>();

                map.Add(node, new Node(node.val, new List<Node>()));
                visited.Enqueue(node);

                while (visited.Count != 0)
                {
                    Node currNode = visited.Dequeue();

                    foreach (Node neighbor in currNode.neighbors)
                    {
                        if (!map.ContainsKey(neighbor))
                        {
                            map.Add(neighbor, new Node(neighbor.val, new List<Node>()));
                            visited.Enqueue(neighbor);

                        }
                        map[currNode].neighbors.Add(map[neighbor]);
                    }
                }

                return map[node];
            }
        }
    }
}
