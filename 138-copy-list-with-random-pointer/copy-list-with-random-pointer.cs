/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node CopyRandomList(Node head) {
        if (head == null) return head;

        var curr = head;
        while(curr != null) {
            var newNode = new Node(curr.val);
            newNode.next = curr.next;
            curr.next = newNode;
            curr = newNode.next;
        }

        var newHead = head.next;
        curr = head;
        while(curr != null) {
            if (curr.random != null) {
                curr.next.random = curr.random.next;
            }
            curr = curr.next.next;
        }
        
        curr = head;
        while(curr != null) {
            var real = curr.next;
            curr.next = real.next;
            if (real.next != null) {
                real.next = real.next.next;
            }
            curr = curr.next;
        }

        return newHead;

    }
}
