package dp;

public class ClimbingStairs {
    public int climbStairs(int n) {
        int[] memo = new int[n + 1];
        int a = 1;
        int b = 1;
        for (int i = 2; i <= n; i++) {
            int c = a + b;
            b = a;
            a = c;
        }

        return a;
    }
}
