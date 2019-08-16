package arrays;

import java.util.Arrays;

public class isUnique {
    //strings.arrays.isUnique that uses an additional data structure to check O(n)
    public static boolean isUniqueWithAdditionalDS(String string) {
        if (string.length() > 128) return false;

        boolean[] chars = new boolean[128];
        for (int i = 0; i < string.length(); i++) {
            int currChar = string.charAt(i);
            if (chars[currChar]) {
                return false;
            }

            chars[currChar] = true;
        }

        return true;
    }
    //strings.arrays.isUnique that uses no additional data structure to check O(n^2)
    public static boolean isUniqueNoDS(String string) {
        if (string.length() > 128) return false;

        for(int i = 0; i < string.length(); i++) {
            for (int j = i + 1; j < string.length(); j++) {
                if(string.charAt(i) == string.charAt(j)) return false;
            }
        }

        return true;
    }
    //strings.arrays.isUnique that uses a sort to achieve O(n) without additional DS.
    public static boolean isUniqueOptimized(String string) {
        char[] stringToChar = string.toCharArray();
        Arrays.sort(stringToChar);
        for (int i = 0; i < stringToChar.length - 1; i++) {
            if(stringToChar[i] == stringToChar[i + 1]) return false;
        }

        return true;
    }
    public static void main(String[] args) {
        System.out.println(isUniqueWithAdditionalDS("abcdefghijklmnopqrstuvwxyz"));
        System.out.println(isUniqueNoDS("abcdefghijklmnopqrstuvwxyz"));
        System.out.println(isUniqueOptimized("abcdefghijklmnopqrstuvwxyz"));
        System.out.println(isUniqueWithAdditionalDS("tttttt"));
        System.out.println(isUniqueNoDS("ttttttt"));
        System.out.println(isUniqueOptimized("ttttttttt"));
    }
}
