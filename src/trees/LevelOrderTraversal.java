package trees;

public class LevelOrderTraversal {
    List<List<Integer>> nodes = new ArrayList<List<Integer>>();

    public void helper(TreeNode node, int depth) {
        if (node == null) {
            return;
        } else {
            if(nodes.size() < depth + 1) {
                nodes.add(new ArrayList<Integer>());
            }

            nodes.get(depth).add(node.val);
            helper(node.left, depth + 1);
            helper(node.right, depth + 1);
            return;
        }
    }
    public List<List<Integer>> levelOrder(TreeNode root) {
        helper(root, 0);
        return nodes;
    }
}
