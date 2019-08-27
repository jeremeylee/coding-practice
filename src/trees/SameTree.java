package trees;

public class SameTree {
    public boolean verify(TreeNode p, TreeNode q) {

        if (p == null && q == null) {
            return true;
        }

        if (p == null || q == null) {
            return false;
        }
        if (p.val != q.val) {
            return false;
        }

        return verify(p.left, q.left) && verify(p.right, q.right);

    }

    public boolean isSameTree(TreeNode p, TreeNode q) {
        return verify(p, q);
    }
}
