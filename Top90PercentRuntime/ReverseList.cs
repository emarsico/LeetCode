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

 // Top 91.51% Runtime
public class Solution {
    public ListNode ReverseList(ListNode head) {
        if(head == null || head.next == null)
        {
            return head;
        }

        ListNode prevNode = head; // 1
        ListNode interNode = head.next; // 2
        head.next = null;
        ListNode futureNode = null;
        if(interNode.next != null)
        {
            futureNode = interNode.next; // 3
        }

        while(futureNode != null)
        {
            
            interNode.next = prevNode; // 2 -> 1
            prevNode = interNode; // 2
            interNode = futureNode;
            futureNode = futureNode.next;

        }

        interNode.next = prevNode;

        return interNode;
    }
}

// [1, 2, 3]
/*
    1 -> 2 -> 3 -> 4    1 2 3
    1 <- 2 // 3 -> 4    2 3 4
    1 <- 2 <- 3 // 4    3 4 null

*/