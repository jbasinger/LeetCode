using System.Collections.Generic;

namespace LeetCode._00002_Add_Two_Numbers
{
    public class Solution
    {
        public class ListNode
        {
            public int val;
            public ListNode next;

            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
            
        }
        
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            return SumLists(l1, l2, 0);
        }

        public ListNode SumLists(ListNode l1, ListNode l2, int carry)
        {
            if (l1 == null && l2 == null && carry == 0)
            {
                return null;
            }
            var val1 = l1 == null ? 0 : l1.val;
            var val2 = l2 == null ? 0 : l2.val;
                
            var sum = val1 + val2 + carry;
                
            carry = sum >= 10 ? 1 : 0;
            if (carry == 1)
            {
                sum -= 10;
            }

            return new ListNode(sum, SumLists(l1?.next, l2?.next, carry));
        }
        
        public ListNode BuildList(int[] input,int index=0)
        {
            return index+1 < input.Length ? new ListNode(input[index], BuildList(input, ++index)) : new ListNode(input[index]);
        }
        
        public int[] Output(ListNode n)
        {
            var res = new List<int>();
            var node = n;
            while (node != null)
            {
                res.Add(node.val);
                node = node.next;
            }

            return res.ToArray();
        }
        
    }
}