public class PalinPerm {

    public static boolean checkPalinPerm(String str) {
        if (str.length() < 2) return true;
        int[] containsChar = new int[128];
        boolean mulligan = false;

        for (int i = 0; i < str.length(); i++) {
            int currChar = str.charAt(i);
            containsChar[currChar]++;
            if (containsChar[currChar] > 2) {
                System.out.println("first false");
                return false;
            }
            if (containsChar[currChar] == 1 && currChar != ' ') {
                mulligan = true;
            } else {
                mulligan = false;
            }
        }

        if (mulligan) {
            return false;
        }
        return true;
    }

    public static void main(String[] args) {
        System.out.println(checkPalinPerm("tactcoa"));

    }
}
