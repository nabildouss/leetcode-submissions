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
    public void ReorderList(ListNode head) {
        if (head == null || head.next == null) return;
        var slow = head;
        var fast = head;
        while(fast.next != null && fast.next.next != null) {
            fast = fast.next.next;
            slow = slow.next;
        }

        var list2 = ReverseList(slow.next);
        slow.next = null;

        MergeTwoLists(head, list2);
    }

    public ListNode ReverseList(ListNode head) {
        if (head == null) return head;
        var curr = head.next;
        var prev = head;
        prev.next = null;
        while(curr != null) {
            var temp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = temp;
        } 
        return prev;
    }

    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        if (list1 == null) return list2;
        if (list2 == null) return list1;
        var head = list1;
        list1 = list1.next;
        var current = head;
        var list1Turn = false;
        while(list1 != null && list2 != null) {
            if (list1Turn) {
                current.next = list1;
                list1 = list1.next;
            }
            else {
                current.next = list2;
                list2 = list2.next;
            }
            list1Turn = !list1Turn;
            current = current.next;
        }
        if (list1 != null) current.next = list1;
        if (list2 != null) current.next = list2;
        return head;
    }
}
