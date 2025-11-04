//The runtime complexity of this solution is O(N)

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
/*
    You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order, and each of their nodes contains a single digit.
    Add the two numbers and return the sum as a linked list.

    You may assume the two numbers do not contain any leading zero, except the number 0 itself.

    Constraints:

    The number of nodes in each linked list is in the range [1, 100].
    0 <= Node.val <= 9
    It is guaranteed that the list represents a number that does not have leading zeros.
*/
