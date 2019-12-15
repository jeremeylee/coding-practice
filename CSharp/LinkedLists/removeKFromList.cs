using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.CSharp.LinkedLists
{
    class removeKFromList
    {
        // Singly-linked lists are already defined with this interface:
        // class ListNode<T> {
        //   public T value { get; set; }
        //   public ListNode<T> next { get; set; }
        // }
        //
        ListNode<int> removeKFromList(ListNode<int> l, int k)
        {
            if (l == null)
            {
                return l;
            }

            ListNode<int> curr = l;
            ListNode<int> prev = null;

            while (curr != null && curr.value == k)
            {
                ListNode<int> temp = curr.next;
                curr.next = null;
                curr = temp;
                l = temp;

            }

            while (curr != null)
            {
                if (curr.value == k)
                {
                    prev.next = curr.next;
                    curr = curr.next;
                }
                else
                {
                    prev = curr;
                    curr = curr.next;
                }


            }
            return l;
        }

    }
}
