import java.util.*;

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
//        Node runner = head.next;
//        Node previous = null;
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


    }
}
