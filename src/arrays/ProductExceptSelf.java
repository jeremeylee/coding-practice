package arrays;

public class ProductExceptSelf {
    public int[] productExceptSelf1(int[] nums) {
        int[] left = new int[nums.length];
        int[] right = new int[nums.length];
        left[0] = 1;
        right[right.length - 1] = 1;

        for (int i = 1; i < left.length; i++) {
            left[i] = left[i - 1] * nums[i - 1];
        }

        for (int i = right.length - 2; i >= 0; i--) {
            right[i] = right[i + 1] * nums[i + 1];
        }

        for (int i = 0; i < nums.length; i++) {
            left[i] = left[i] * right[i];
        }

        return left;

    }

    public int[] productExceptSelf2(int[] nums) {
        int[] output = new int[nums.length];
        output[0] = 1;

        for (int i = 1; i < output.length; i++) {
            output[i] = output[i - 1] * nums[i - 1];
        }
        int right = 1;
        for (int i = nums.length - 1; i >= 0; i--) {
            output[i] = output[i] * right;
            right *= nums[i];
        }

        return output;

    }
}
