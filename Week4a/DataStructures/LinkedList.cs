public class LinkedList
{
    private Node head;
    private Node tail;

    public LinkedList() {
        head = null;
    }

    public void AddLast(int value) {
        
        Node newNode = new Node(value);

        if (head == null) {

            head = newNode;

        } else {

            Node current = head;

            while(current.Next != null) {
                current = current.Next;
            }

            current.Next = newNode;
            tail = newNode;
        }
    }

    public void AddFirst(int data) {
        Node newNode = new Node(data);
        newNode.Next = head;
        head = newNode;
    }

    public bool Search(int data) {
        Node current = head;
        while(current != null) {
            if(current.Data == data) {
                return true;
            }
            current = current.Next;
        }
        return false;
    }

    public void Delete(int data) {
        if(head == null){
            return;
        }

        if(head.Data == data) {
            head = head.Next;
            return;
        }

        Node current = head;
        
        while (current.Next != null && current.Next.Data != data) {
            current = current.Next;
        }

        if(current.Next != null) {
            current.Next = current.Next.Next;
        }

    }

    public void Display() {
        Node current = head;

        while(current != null) {
            Console.Write(current.Data + " --> ");
            current = current.Next;
        }
    }

}