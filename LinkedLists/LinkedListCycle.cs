/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        if(head==null || head.next==null || head.next.next==null){return false;}
        else{
        ListNode pointerf=head.next.next;
        ListNode pointers=head.next;
        while( pointerf != pointers){
            pointerf=pointerf.next;
            pointers=pointers.next;
            if(pointerf==null || pointerf.next==null){
                return false;
            }
            else{ pointerf=pointerf.next;}
        }
        return true;
        }
    }
}