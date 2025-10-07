
// Definition for singly-linked list.
public class ListNode {
     public int val;
     public ListNode next;
     public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
     }
 }

public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        int carry = 0;
        ListNode head1 = l1;
        ListNode head2 = l2;
        ListNode start = new ListNode();
        ListNode current = start;
        int n1 = 0;
        int n2 = 0;
        bool check = false;
        while (check == false)
        {
            if (head1 != null)
            {
                n1 = head1.val;
                head1 = head1.next;
            }
            else
            {
                n1 = 0;
            }
            if (head2 != null)
            {
                n2 = head2.val;
                head2 = head2.next;
            }
            else
            {
                n2 = 0;
            }
            int add = n1 + n2 + carry;
            if (add >= 10)
            {
                carry = 1;
                current.val = add % 10;
            }
            else
            {
                carry = 0;
                current.val = add;
            }
            if (head1 != null || head2 != null)
            {
                current.next = new ListNode();
                current = current.next;
            }
            else if (head1 == null && head2 == null)
            {
                if (carry == 1)
                {
                    current.next = new ListNode(1);
                }
                check = true;
            }
        }
        return start;
    }
}
