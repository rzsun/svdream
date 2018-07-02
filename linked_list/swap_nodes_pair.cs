// https://leetcode.com/problems/swap-nodes-in-pairs/

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode SwapPairs(ListNode head) {
        if (head == null || head.next == null) {
            return head;
        }
        ListNode returnHead = head.next;
        
        ListNode current = head;
        ListNode previous = null;
        while(current != null && current.next != null) {
            if (previous != null) {
                previous.next = current.next;
            }
            
            ListNode next = current.next;
            current.next = next.next;
            next.next = current;
            previous = current;
            current = current.next;
        }
        
        return returnHead;
    }
}