using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CSharp.AddTwoNumbersSolution
{
    internal class AddTwoNumbersSolution
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
            decimal val1 = 0;
            decimal val2 = 0;
            var check = false;
            var digit = 0;
            var n1 = l1;
            var n2 = l2;
            while (check == false)
            {
                var currentValue = n1.val;
                n1 = n1.next;
                val1 += (decimal)(currentValue * Math.Pow(10, digit));
                digit += 1;
                if (n1 == null)
                {
                    check = true;
                    digit = 0;
                }
            }
            check = false;
            while (check == false)
            {
                var currentValue = n2.val;
                n2 = n2.next;
                val2 += (decimal)(currentValue * Math.Pow(10, digit));
                digit += 1;
                if (n2 == null)
                {
                    check = true;
                    digit = 0;
                }
            }
            var result = val1 + val2;
            String resultString = result.ToString();
            var resultArray = resultString.ToCharArray();
            ListNode head = null;
            for (int i = 0; i < resultArray.Length; i++)
            {
                ListNode currentNode = new ListNode((resultArray[i] - '0'), head);
                head = currentNode;
            }
            return head;
        }
        

    }
}
