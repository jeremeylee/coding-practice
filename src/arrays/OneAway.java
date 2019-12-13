package arrays;

public class OneAway {

    public static boolean checkOneAway(String str1, String str2) {
        int[] charMap1 = new int[128];
        int match = 0;

        for (int i = 0; i < str1.length(); i++) {
            charMap1[str1.charAt(i)]++;
        }

        for (int i = 0; i < str2.length(); i++) {
            if (charMap1[str2.charAt(i)] > 0) {
                match++;
            }
        }

        if (Math.abs(match - str1.length()) == 1) {
            return true;
        }
        return false;
    }

    public static boolean checkOneAwayAlternate(String str1, String str2) {
        if (str1.length() == str2.length()) {
           return oneEditAway(str1, str2);
        }

        if (str1.length() - str2.length() == 1) {
            return oneInsertAway(str2, str1);
        }

        if (str2.length() - str1.length() == 1) {
            return oneInsertAway(str1, str2);
        }

        return false;
    }

    public static boolean oneEditAway(String str1, String str2) {
        boolean difference = false;

        for (int i = 0; i < str1.length(); i++) {
            if(str1.charAt(i) != str2.charAt(i)) {
                if (difference) {
                    return false;
                }

                difference = true;
            }
        }
        return true;
    }

    public static boolean oneInsertAway(String str1, String str2) {
        int index1 = 0;
        int index2 = 0;

        while (index1 < str1.length() && index2 < str2.length()) {
            if (str1.charAt(index1) != str2.charAt(index2)) {
                if (index1 != index2) {
                    return false;
                }

                index2++;
            } else {
                index1++;
                index2++;
            }
        }
        return true;
    }
    public static void main (String[] args) {
        System.out.println(checkOneAway("pale", "bale"));
        System.out.println(checkOneAwayAlternate("pale", "bake"));

    }
}
