using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.CSharp.LinkedLists
{
    class isListPalindrome
    {
        // Singly-linked lists are already defined with this interface:
        // class ListNode<T> {
        //   public T value { get; set; }
        //   public ListNode<T> next { get; set; }
        // }
        //
        bool isListPalindrome(ListNode<int> l)
        {
            if (l == null || l.next == null)
            {
                return true;
            }

            ListNode<int> fast = l;
            ListNode<int> mid = l;

            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                mid = mid.next;
            }

            ListNode<int> prev = mid;
            ListNode<int> curr = mid.next;

            while (curr != null)
            {
                ListNode<int> temp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = temp;
            }

            curr = l;
            mid.next = null;

            while (curr != null && prev != null)
            {
                if (curr.value != prev.value)
                {
                    return false;
                }

                curr = curr.next;
                prev = prev.next;
            }

            return true;
        }

    }
}
