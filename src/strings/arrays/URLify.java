package strings.arrays;

public class URLify {

    public static char[] convertToUrl(char[] str, int trueLength) {
        int spaceCount = countAmountSpace(str, trueLength, ' ');
        int realIndex = trueLength - 1 + spaceCount * 2;

        for (int i = trueLength - 1; i >= 0; i--) {
            if (str[i] == ' ') {
                str[realIndex] = '0';
                str[realIndex - 1] = '2';
                str[realIndex - 2] = '%';
                realIndex -= 3;
            } else {
                str[realIndex] = str[i];
                realIndex--;
            }
        }

        return str;
    }

    public static int countAmountSpace(char[] str, int trueLength, int space) {
        int count = 0;

        for (int i = 0; i < trueLength - 1; i++) {
            if (str[i] == space && str[i + 1] == space) {
                return count;
            }
            if (str[i] == space) {
                count++;
            }
        }

        return count;
    }

    public static void main (String[] args) {
        String str = "Mr John Smith    ";
        char[] strChar = str.toCharArray();
        System.out.println(convertToUrl(strChar, 13));

    }
}
