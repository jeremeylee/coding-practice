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
}
