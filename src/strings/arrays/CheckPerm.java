package strings.arrays;

import java.util.Arrays;

public class CheckPerm {

    public static boolean checkPermutation1(String str1, String str2) {
        if (str1.length() != str2.length()) return false;

        char[] char1 = str1.toCharArray();
        char[] char2 = str2.toCharArray();
        Arrays.sort(char1);
        Arrays.sort(char2);
        for (int i = 0; i < char1.length; i++) {
            if (char1[i] != char2[i]) return false;
        }

        return true;
    }

    public static boolean checkPermutation2(String str1, String str2) {
        if (str1.length() != str2.length()) return false;

        char[] char1 = str1.toCharArray();
        char[] char2 = str2.toCharArray();

        int[] containsChar = new int[128];

        for (int i = 0; i < str1.length(); i++) {
            int currChar = str1.charAt(i);
            containsChar[currChar]++;
        }

        for (int i = 0; i < str2.length(); i++) {
            int currChar = str2.charAt(i);
            containsChar[currChar]--;

            if(containsChar[currChar] < 0) {
                return false;
            }
        }

        return true;
    }

    public static void main (String[] args) {
        System.out.println(checkPermutation1("test", "tets"));
        System.out.println(checkPermutation2("abcd", "efgh"));

    }
}
