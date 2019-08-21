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

    public ListNode middleNode1(ListNode head) {
        ListNode[] nodes = new ListNode[100];
        int i = 0;
        while (head != null) {
            nodes[i] = head;
            head = head.next;
            i++;
        }

        return nodes[i/2];
    }

    public ListNode middleNode2(ListNode head) {

        ListNode slow = head;
        ListNode fast = head;
        while (fast != null && fast.next != null) {
            slow = slow.next;
            fast = fast.next.next;
        }
        return slow;
    }
}
