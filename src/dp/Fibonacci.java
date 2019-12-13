package dp;

public class Fibonacci {
    public int fib(int N) {
        if (N == 0) {
            return 0;
        }
        int a = 1;
        int b = 1;

        for (int i = 2; i < N; i++) {
            int c = a + b;
            b = a;
            a = c;
        }

        return a;
    }
}
