package dp;

public class UniquePaths {
    public int calcPathsMemo(int row, int col, int m, int n, int[][] memo) {
        if (row > m - 1 || col > n - 1) {
            return 0;
        }

        if (memo[row][col] != 0) {
            return memo[row][col];
        }

        if (row == m - 1 && col == n - 1) {
            return 1;
        }

        if (memo[row][col] == 0) {
            memo[row][col] = calcPaths(row + 1, col, m, n, memo) + calcPaths(row, col + 1, m, n, memo);
        }

        return memo[row][col];
    }

    public int uniquePathsMemo(int m, int n) {
        int[][] memo = new int[m][n];
        for (int[] row: memo) {
            Arrays.fill(row, 0);
        }
        return calcPaths(0, 0, m, n, memo);
    }
    public int calcPathsRecurse(int row, int col, int m, int n) {
        if (row > m - 1 || col > n - 1) {
            return 0;
        }

        if (row == m - 1 && col == n - 1) {
            return 1;
        }

         return calcPaths(row + 1, col, m, n, memo) + calcPaths(row, col + 1, m, n, memo);


    }

    public int uniquePathsRecurse(int m, int n) {
        return calcPaths(0, 0, m, n);
    }
}
