package linkedlists;

import java.util.HashSet;
import linkedlists.LinkedList.*;

public class LinkedListPractice {
    private static Node deleteDups(Node head) {
        HashSet<Integer> set = new HashSet<Integer>();
        Node previous = null;
        while (head != null) {
            if(set.contains(head.data)) {
                previous.next = head.next;

            } else {
                set.add(head.data);
                previous = head;

            }
            head = head.next;
        }

        return head;
    }
    private static Node deleteDupsAlternate(Node head) {
        Node current = head;
//        linkedlists.Node runner = head.next;
//        linkedlists.Node previous = null;
//        display(runner);
        while (current != null) {
            Node runner = current;
            while (runner.next != null) {
                if (runner.next.data == current.data) {
                    runner.next = runner.next.next;
                } else {
                    runner = runner.next;
                }
            }
            current = current.next;
        }
        return current;
    }

    public static boolean linkedListSearch(Node head, int find) {
        if (head == null) return false;
        return head.data == find || linkedListSearch(head.next, find);
    }
    public static void display(Node head) {
        Node n = head;
        while (n != null) {
            System.out.print(n.data + "->");
            n = n.next;
        }
    }
    public static void main (String[] args) {
        Node n = new Node(1);
        n.next = new Node(2);
        n.next.next = new Node(2);
        n.next.next.next = new Node(3);
        n.next.next.next.next = new Node(4);
        n.next.next.next.next.next = new Node(4);
        n.next.next.next.next.next.next = new Node(2);
        deleteDupsAlternate(n);
        display(n);
        System.out.println(linkedListSearch(n, 4));
        LinkedList list = new LinkedList();
        list = LinkedList.addNode(list, 3);
        list = LinkedList.addNode(list, 4);
        list = LinkedList.addNode(list, 5);
        list = LinkedList.addNode(list, 6);
        list = LinkedList.addNode(list, 6);
        list = LinkedList.addNode(list, 6);

        System.out.println(LinkedList.linkedListSize(list));
        System.out.println(LinkedList.kthToLast(list, 1));
        System.out.println(LinkedList.linkedListSizeRecursive(list.head));
        System.out.println(LinkedList.kthToLastRecursive(list.head, LinkedList.linkedListSizeRecursive(list.head), 2));
        LinkedList.printList(LinkedList.deleteMiddle(list));
    }
}
