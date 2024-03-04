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
    public ListNode RotateRight(ListNode head, int k) {
        // time O(n)
        // space O(1)

        if(head == null || head.next == null || k == 0) return head;
        int length = 1;
        ListNode tail = head;
        while(tail.next != null)
        {
            length++;
            tail = tail.next;
        }

        k = k % length;
        if(k == 0) return head;
        
        tail.next = head;

        int steps = length - k;
        ListNode newTail = tail;

        while(steps > 0)
        {
            newTail = newTail.next;
            steps--;
        }
        ListNode newHead = newTail.next;
        newTail.next = null;
        return newHead;         
    }
}
