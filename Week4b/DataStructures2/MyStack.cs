using System;

public class MyStack
{

    private class Node
    {
        public int Val {get;}
        public Node Next {get;}

        public Node(int val, Node next) {
            Val = val;
            Next = next;
        } 
    }


    private Node head;
    private int count;

    public MyStack() {}

    public void Push(int x) {
        head = new Node(x, head);
        count++;
    }

    public void Pop() {
        if(head == null) {
            Console.WriteLine("Head is null!");
        }
        head = head.Next;
        count--;
    }

    public int Peek() {
        if(head == null) {
            Console.WriteLine("Head is null!");
        }

        return head.Val;
    }

    public bool IsEmpty() {
        return head == null;
    }

}