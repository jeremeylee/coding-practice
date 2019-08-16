package linkedlists;

public class LinkedList {
    Node head;

    static class Node {
        Node next;
        int data;

        public Node(int data) {
            this.data = data;
        }
    }

    public static LinkedList addNode(LinkedList list, int data) {
        Node n = new Node(data);
        n.next = null;
        if (list.head == null) {
            list.head = n;
        } else {
            Node last = list.head;
            while (last.next != null) {
                last = last.next;
            }
            last.next = n;
        }
        return list;
    }
    public static LinkedList deleteNode(LinkedList list, int data) {
        Node head = list.head;
        if (head.data == data) {
            head = head.next;
        }
        Node previous = null;

        while(head != null) {
            if (head.data == data) {
                previous.next = head.next;
            } else {
                previous = head;
            }
            head = head.next;
        }

        return list;
    }

    public static void printList(LinkedList list) {
        Node head = list.head;
        while (head != null) {
            System.out.println(head.data + "->");
            head = head.next;
        }
    }

    public static int linkedListSize(LinkedList list) {
        Node head = list.head;
        int size = 0;
        while (head != null) {
            size++;
            head = head.next;
        }
        return size;
    }
    public static int linkedListSizeRecursive(Node head) {
        if (head == null) return 0;
        return 1 + linkedListSizeRecursive(head.next);
    }
    public static int kthToLast(LinkedList list, int k) {
        int size = (linkedListSize(list));
        Node head = list.head;

        for (int i = 0; i < size - k; i++) {
            head = head.next;
        }
        return head.data;
    }

    public static int kthToLastRecursive(Node head, int size, int k) {
         if (size == k) return head.data;
         return kthToLastRecursive(head.next, size - 1, k);
    }

    public static LinkedList deleteMiddle(LinkedList list) {
        int size = linkedListSize(list);
        Node head = list.head;
        Node temp = head;
        int valueToDelete = 0;
        for (int i = 0; i < size/2; i++) {
            head = head.next;
        }
        valueToDelete = head.data;
        Node previous = null;
        while (temp != null) {
            if (temp.data == valueToDelete) {
                previous.next = temp.next;
                break;
            } else {
                previous = temp;
            }
            temp = temp.next;
        }

        return list;
    }
}
