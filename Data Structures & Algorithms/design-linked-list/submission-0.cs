public class MyLinkedList {
    private Node head;
    private int size;
    
    public MyLinkedList() {
        head = null;
        size = 0;
    }
    
    public int Get(int index) {
        if(index<0 || index >=size){
            return -1;
        }
        else{
            Node current = head;
            for(int i=0;i<index;i++){
                current = current.next;
            }
            return current.val;
        }
    }
    
    public void AddAtHead(int val) {
        Node newNode = new Node(val);
        newNode.next = head;
        head = newNode;
        size++;
    }
    
    public void AddAtTail(int val) {
        Node newNode = new Node(val);
        if(size==0){
            head = newNode;
            size++;
        }
        else{
            Node current = head;
            for(int i=0;i<size-1;i++){
                current = current.next;
            }
            current.next = newNode;
            size++;
        }
        
    }
    
    public void AddAtIndex(int index, int val) {
       if(index>size){
        return;
       }
       if(index<=0){
        AddAtHead(val);
        return;
       }
       if(index==size){
        AddAtTail(val);
        return;
       }
       else{
            Node current = head;
            Node newNode = new Node(val);
            for(int i=0;i<index-1;i++){
                current = current.next;
            }
            newNode.next = current.next;
            current.next = newNode;
            size ++;
        }
    }
    
    public void DeleteAtIndex(int index) {
        if(index>=size || index <0){
            return;
        }
        if(index==0){
            head = head.next;
            size--;
            return;
        }
        else{
            Node current = head;
            for(int i=0;i<index-1;i++){
                current = current.next;
            }
            current.next = current.next.next;
            size--;
        }  
    }
}
public class Node{
        public int val;
        public Node next;

        public Node(int val){
            this.val = val;
            this.next = null;
        }
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