using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.CSharp.LinkedLists
{
    class AddTwoNumbers
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode output = new ListNode(0);
            ListNode head = output;
            int carry = 0;

            while (l1 != null || l2 != null)
            {
                if (l1 != null)
                {
                    carry += l1.val;
                    l1 = l1.next;
                }

                if (l2 != null)
                {
                    carry += l2.val;
                    l2 = l2.next;
                }
                output.val += carry;
                carry = output.val / 10;
                output.val %= 10;
                Console.WriteLine(output.val);
                if (l1 != null || l2 != null)
                {
                    output.next = new ListNode(0);
                    output = output.next;
                }

            }
            if (carry > 0)
            {
                output.next = new ListNode(carry);
                output = output.next;
            }
            return head;

        }
    }
}
