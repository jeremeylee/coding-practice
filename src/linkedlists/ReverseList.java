package linkedlists;

public class ReverseList {
    public ListNode iterativeReverseList(ListNode head) {
        ListNode prev = null;
        ListNode curr = head;
        while (curr != null) {
            ListNode next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }

        return prev;
    }
    public ListNode recursiveReverseList(ListNode head) {
        if (head == null || head.next == null) {
            return head;
        }

        ListNode reverseListHead = recursiveReverseList(head.next);
        head.next.next = head;
        head.next = null;
        return reverseListHead;
    }
}

