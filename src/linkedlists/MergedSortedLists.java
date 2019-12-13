package linkedlists;

public class MergedSortedLists {
    public ListNode mergeTwoLists(ListNode l1, ListNode l2) {
        ListNode merged = new ListNode(0);
        ListNode save = merged;
        while (l1 != null && l2 != null) {
            if (l1.val <= l2.val) {
                save.next = l1;
                l1 = l1.next;
            } else {
                save.next = l2;
                l2 = l2.next;
            }
            save = save.next;
        }

        if (l1 != null) {
            save.next = l1;

        }
        if (l2 != null) {
            save.next = l2;

        }

        return merged.next;

    }
}
