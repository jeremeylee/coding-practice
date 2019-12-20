using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.CSharp.LinkedLists
{
    class mergeTwoLinkedLists
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode merged = new ListNode(0);
            ListNode head = merged;
            while (l1 != null && l2 != null)
            {
                if (l1.val >= l2.val)
                {
                    merged.next = l2;
                    l2 = l2.next;
                }
                else
                {
                    merged.next = l1;
                    l1 = l1.next;
                }

                merged = merged.next;
            }

            if (l1 != null)
            {
                merged.next = l1;
                merged = merged.next;
            }

            if (l2 != null)
            {
                merged.next = l2;

            }

            return head.next;
        }

    }
}
