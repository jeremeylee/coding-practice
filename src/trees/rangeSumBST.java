package trees;

public class rangeSumBST {
    public int rangeSumBST(TreeNode root, int L, int R) {
        int sum = 0;
        if (root != null) {
            sum += rangeSumBST(root.left, L, R);
            sum += rangeSumBST(root.right, L, R);
            if (root.val >= L && root.val <= R) {
                sum += root.val;
                return sum;
            } else {
                return sum;
            }

        }
        return sum;
    }
}
}
