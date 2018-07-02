// https://leetcode.com/problems/remove-nth-node-from-end-of-list

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        List<ListNode> nodeList = new List<ListNode>();
        
        ListNode current = head;
        while(current != null) {
            nodeList.Add(current);
            current = current.next;
        }
        
        if (n > nodeList.Count) {
            return null;
        }
        
        if (n == nodeList.Count) {
            return head.next;
        }
        
        nodeList[nodeList.Count - n - 1].next = nodeList[nodeList.Count - n].next;
        
        return head;
    }
}