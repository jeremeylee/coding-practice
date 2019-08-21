package linkedlists;

public class PalindromeList {
    public boolean isPalindrome1(ListNode head) {
        if(head == null || head.next == null) {
            return true;
        }
        ListNode curr = head;
        ListNode reverseListHead = null;
        ArrayList<Integer> data = new ArrayList<Integer>();

        while (curr != null) {
            data.add(curr.val);
            ListNode next = curr.next;
            curr.next = reverseListHead;
            reverseListHead = curr;
            curr = next;
        }
        for (int i = 0; i < data.size(); i++) {
            if (reverseListHead.val != data.get(i)) {
                return false;
            } else {
                reverseListHead = reverseListHead.next;
            }
        }
        return true;
    }

    public boolean isPalindrome2(ListNode head) {
        int size = 0;
        ListNode findSize = head;
        while (findSize != null) {
            size++;
            findSize = findSize.next;
        }
        if (size < 2) {
            return true;
        }
        ListNode curr = head;
        ListNode prev = null;

        for (int i = 0; i < size/2; i++) {
            ListNode next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }

        if (size % 2 == 1) {
            curr = curr.next;
        }

        for (int i = 0; i < size/2; i++) {
            if (prev.val != curr.val) {
                return false;
            } else {
                prev = prev.next;
                curr = curr.next;
            }
        }

        return true;
    }
}
