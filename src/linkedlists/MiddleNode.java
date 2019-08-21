package linkedlists;

public class MiddleNode {
    public ListNode middleNode(ListNode head) {
        int size = 0;
        ListNode n = head;
        while (n != null) {
            n = n.next;
            size++;
        }

        for(int i = 0; i < size/2; i++) {
            head = head.next;
        }

        return head;
    }
}
