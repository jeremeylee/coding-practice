package trees;

public class MaxDepth {
    public int maxDepth(TreeNode root) {
        if (root == null) {
            return 0;
        }

        int leftHeight = maxDepth(root.left) + 1;
        int rightHeight = maxDepth(root.right) + 1;

        return leftHeight > rightHeight ? leftHeight : rightHeight;
    }
}
