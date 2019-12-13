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

    public boolean hasCycle2(ListNode head) {
        if (head == null || head.next == null) {
            return false;
        }
        ListNode slow = head;
        ListNode fast = head.next;
        while (slow != fast) {
            if (fast == null || fast.next == null) {
                return false;
            }
            slow = slow.next;
            fast = fast.next.next;
        }

        return true;
    }
}
}
