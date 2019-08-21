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

    public ListNode middleNode2(ListNode head) {
        ListNode[] nodes = new ListNode[100];
        int i = 0;
        while (head != null) {
            nodes[i] = head;
            head = head.next;
            i++;
        }

        return nodes[i/2];
    }
}
