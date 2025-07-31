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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        if (head == null) return head;
        
        var first = head;
        for(int i = 0; i < n; i++) {
            first = first.next;
        }
        if (first == null) return head.next;
        var second = head;
        while(first.next != null) {
            second = second.next;
            first = first.next;
        }
        if (second.next == null) return null;        
        var t = second.next;
        second.next = t.next;
        return head;
    }
}
