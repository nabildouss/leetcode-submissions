/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode dummyHead = new ListNode(-1, null);
        ListNode curr = dummyHead;
        var carry = 0;
        while(l1 != null && l2 != null) {
            var a = l1.val;
            l1 = l1.next;
            var b = l2.val;
            l2 = l2.next;
            var sum = a + b + carry;
            carry = sum / 10;
            var newNode = new ListNode(sum % 10, null);
            curr.next = newNode;
            curr = newNode;
        }

        while (l1 != null) {
            var a = l1.val;
            l1 = l1.next;
            var sum = a + carry;
            carry = sum / 10;
            var newNode = new ListNode(sum % 10, null);
            curr.next = newNode;
            curr = newNode;        
        }

        while (l2 != null) {
            var a = l2.val;
            l2 = l2.next;
            var sum = a + carry;
            carry = sum / 10;
            var newNode = new ListNode(sum % 10, null);
            curr.next = newNode;
            curr = newNode;
        }

        if (carry != 0) {
            var newNode = new ListNode(carry, null);
            curr.next = newNode;
            curr = newNode;
        }
        return dummyHead.next;

    }
}
