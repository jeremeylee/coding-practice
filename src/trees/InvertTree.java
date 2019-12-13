package trees;

public class InvertTree {
    public void invert(TreeNode root) {
        if (root != null) {
            TreeNode temp = root.left;
            root.left = root.right;
            root.right = temp;
            invert(root.left);
            invert(root.right);
            return;
        }

        return;
    }

    public TreeNode invertTree(TreeNode root) {
        invert(root);
        return root;
    }
}
