using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.CSharp.LinkedLists
{
    class addTwoHugeNumbers
    {// Singly-linked lists are already defined with this interface:
     // class ListNode<T> {
     //   public T value { get; set; }
     //   public ListNode<T> next { get; set; }
     // }
     //
        ListNode<int> addTwoHugeNumbers(ListNode<int> a, ListNode<int> b)
        {
            ListNode<int> output = new ListNode<int>();
            ListNode<int> head = output;
            int carry = 0;

            a = reverseList(a);
            b = reverseList(b);

            while (b != null || a != null)
            {
                if (b != null)
                {
                    carry += b.value;
                    b = b.next;
                }

                if (a != null)
                {
                    carry += a.value;
                    a = a.next;
                }

                output.value = carry % 10000;
                output.next = new ListNode<int>();
                output = output.next;
                carry /= 10000;
            }

            if (carry > 0)
            {
                output.value = carry;
                output.next = new ListNode<int>();
                output = output.next;
            }
            head = reverseList(head);
            return head.next;
        }

        ListNode<int> reverseList(ListNode<int> head)
        {
            ListNode<int> curr = head;
            ListNode<int> prev = null;

            while (curr != null)
            {
                ListNode<int> temp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = temp;
            }

            return prev;
        }
    }
}
