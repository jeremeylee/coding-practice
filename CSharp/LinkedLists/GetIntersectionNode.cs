using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.CSharp.LinkedLists
{
    class GetIntersectionNode
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            int ALength = GetLength(headA);
            int BLength = GetLength(headB);
            if (ALength > BLength)
            {
                while (ALength > BLength)
                {
                    headA = headA.next;
                    ALength--;
                }
            }
            else if (ALength < BLength)
            {
                while (BLength > ALength)
                {
                    headB = headB.next;
                    BLength--;
                }
            }

            while (headA != headB && headA != null && headB != null)
            {
                headA = headA.next;
                headB = headB.next;
            }

            return headA == headB ? headA : null;

        }

        public int GetLength(ListNode head)
        {
            int length = 0;
            while (head != null)
            {
                head = head.next;
                length++;
            }

            return length;
        }
    }
}
