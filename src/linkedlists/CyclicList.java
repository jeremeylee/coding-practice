package linkedlists;

public class CyclicList {
    public boolean hasCycle1(ListNode head) {
        HashSet<ListNode> node = new HashSet<ListNode>();
        while (head != null) {
            if (node.contains(head.next)) {
                return true;
            } else {
                node.add(head);
                head = head.next;
            }
        }

        return false;

    }
}
