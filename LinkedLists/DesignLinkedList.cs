public class MyLinkedList {
    

    
    /** Initialize your data structure here. */
    public MyLinkedList() {    }
    
    public class Node {
        
        public int val {get;set;}
        public Node next {get;set;}
        public Node(int val){
            //Console.WriteLine("Call for Node");
            this.val=val;
        }
    }
    
    public Node head= null;
    int length=0;

    
    /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
    public int Get(int index) {
        Console.WriteLine("Call for Get");
        int counter=0;
        Node c_n=head;
        if (head == null || index<0 || index>length-1 ){
            return -1;
        }
        else{
            while (counter<=index-1){
                c_n=c_n.next;
                counter++;
            }
            return c_n.val;
        }
        
    }
    
    /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
    public void AddAtHead(int val) {
        //Console.WriteLine("Call for AddAtHead");
        Node temp = new Node(val);
        Node oldHead= head;
        Node newHead= null;
        if(head==null){
            head = temp;
            length++;
        }
        else{
            newHead=temp;
            newHead.next=oldHead;
            head=newHead;
            length++;
        }
        //PrintList();
    }
    
    /** Append a node of value val to the last element of the linked list. */
    public void AddAtTail(int val) {
        //Console.WriteLine("Call for AddAtTail");
        Node temp = new Node(val);
        Node tail = head;
        if(head==null){
            head = temp;
            length++;
        }
        else{
            for(int n=0;n<length-1;n++){
                tail= tail.next;
            }
            //Console.WriteLine("Call for AddAtTail-before assign");
            //Console.WriteLine(tail);
            tail.next = temp;
            //Console.WriteLine("Call for AddAtTail-after assign");
            length++; 
        }
        //PrintList();
    }
    
    /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
    public void AddAtIndex(int index, int val) {
        //Console.WriteLine("Call for AddIndex");
        if(0<index&&index<length){
            Node temp= new Node(val);
            Node prev=head;
            for(int n=0;n<index-1;n++){
                prev= prev.next;
            }
            temp.next=prev.next;
            prev.next=temp;
            length++;
            //PrintList();
            
        }
        else if(index==length){
            AddAtTail(val);
            
        }
        else if(index==0){
            AddAtHead(val);
            
        }
        
        
    }
    
    /** Delete the index-th node in the linked list, if the index is valid. */
    public void DeleteAtIndex(int index) {
        
        if(index>0 && index<length){
            
            Node prev=head;
            Node todel;
            for(int n=0;n<index-1;n++){
                prev= prev.next;
            }
            todel=prev.next;
            
            prev.next=todel.next;
            length--;
            //Console.WriteLine("Call for DelIndex, new index {0}",length);
        }
        if(index==0){
            //Console.WriteLine("Call for Del Head");
            head=head.next;
            length--;
        }
        //PrintList();
    }
    /** Debug print function
    public void PrintList(){
        Console.WriteLine("After function the list is {0} long" ,length);
        Node ll=head;
            for(int n=0;n<length;n++){
                Console.WriteLine(ll.val);
                ll= ll.next;
            }
    }
    */

}

/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */