using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.CSharp.LinkedLists
{
    class mergeTwoLinkedLists
    {// Singly-linked lists are already defined with this interface:
     // class ListNode<T> {
     //   public T value { get; set; }
     //   public ListNode<T> next { get; set; }
     // }
     //
        ListNode<int> mergeTwoLinkedLists(ListNode<int> l1, ListNode<int> l2)
        {
            if (l1 == null && l2 == null)
            {
                return null;
            }

            ListNode<int> merged = new ListNode<int>();
            ListNode<int> head = merged;

            while (l1 != null && l2 != null)
            {
                if (l1.value >= l2.value)
                {
                    merged.value = l2.value;
                    l2 = l2.next;
                }
                else
                {
                    merged.value = l1.value;
                    l1 = l1.next;
                }

                merged.next = new ListNode<int>();
                merged = merged.next;
            }

            if (l1 != null)
            {
                Console.WriteLine("l1");
                merged.value = l1.value;
                merged.next = l1.next;
            }

            if (l2 != null)
            {
                Console.WriteLine("l2");
                merged.value = l2.value;
                merged.next = l2.next;
            }

            return head;
        }

    }
}
