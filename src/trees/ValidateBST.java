package trees;

public class ValidateBST {
    boolean valid = true;

    public boolean isValidBST(TreeNode root) {
        verify(root, null, null);
        return valid;
    }

    public void verify(TreeNode node, Integer min, Integer max) {
        if(node != null) {
            if((min != null && node.val <= min) || (max != null && node.val >= max)) {
                valid = false;
                return;
            }
            verify(node.left, min, node.val);
            verify(node.right, node.val, max);
        }

        return;
    }
}
