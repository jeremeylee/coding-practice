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

    public static void main (String[] args) {
        System.out.println(checkOneAway("pale", "bake"));
    }
}
