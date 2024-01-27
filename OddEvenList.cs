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


 // O(n) Computational Complexity
// 1/27/24



public class Solution {
    public ListNode OddEvenList(ListNode head) {
        int index = 1;
        ListNode current = head;
        ListNode evenHead = null;
        ListNode evenTail = null;

        if(head == null || head.next == null){ return head;}

        evenHead = head.next;
        evenTail = head.next;

        while(current.next != null && current.next.next != null)
        {
            if(index % 2 == 0)
            {
                // Even Indexed Node

                ListNode evenNode = current.next;
                current.next = current.next.next;
                evenTail.next = evenNode;
                evenTail = evenNode;
            }
            else
            {
                // Odd Indexed Node

                ListNode evenNode = current.next;
                ListNode oddNode = current.next.next;
                evenNode.next = oddNode.next;
                current.next = oddNode;
                evenTail.next = evenNode;
                evenTail = evenTail.next;
            }

            index++;
            current = current.next;
        }

        if(current.next != null) {
            evenTail.next = current.next;
            evenTail = current.next;
        }

        evenTail.next = null;
        current.next = evenHead;

        return head;
    }
}

/*
1 <- 2 <- 3 <- 4 <- 5 <- 6 <- 7
1 <- 3 2 <- 4 <- 5 <- 6 <- 7
1 <- 3 <- 5 2 <- 4 <- 6 <- 7
1 <- 3 <- 5 <- 7 2 <- 4 <- 6
1 <- 3 <- 5 <- 7 <- 2 <- 4 <- 6

1 2 3 4 5 6 7
1 3 2 4 5 6 7
1 3 5 2 4 6 7
1 3 5 7 2 4 6

1 <- 3 <- 4 <- 5 <- 6 <- 7, 2
*/