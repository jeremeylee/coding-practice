public class StringCompression {

    public static String compress(String str) {
        int count = 1;
        StringBuilder compressed = new StringBuilder();
        for (int i = 0; i < str.length() - 1; i++) {
            if (str.charAt(i) != str.charAt(i+1) || (i+1) >= str.length()) {
                compressed.append(str.charAt(i));
                compressed.append(count);
                count = 1;
            } else {
                count++;
            }
        }

        if (compressed.length() > str.length()) {
            return str;
        }
        return compressed.toString();
    }

    public static void main (String[] args) {
        System.out.println(compress("aabcccccaaa"));
    }
}
