using System;

public class MyQueue : IMyQueue 
{
    private class Node 
    {
        public int Data {get;}
        public Node Next { get; set; }

        public Node(int d){
            Data = d;
            Next = null;
        }
    } 

    private Node front;
    private Node rear;
    private int count;

    public MyQueue() {
        front = null;
        rear = null;
        count = 0;
    }   

    public void Enqueue(int x) {
        
        Node newNode = new Node(x);

        if(rear == null) {
            front = rear = newNode;
        } else {
            rear.Next = newNode;
            rear = newNode;
        }
        count++;
    }

    public int Dequeue() {
        //does it have a value -- IsEmtpy???
        if(IsEmpty()) {
            //throw exception
            Console.WriteLine("Queue is empty!");
            return 0;
        }

        int value = front.Data;
        front = front.Next;

        if(front == null) {
            rear = null;
        }

        count--;
        return value;
    }

    public int Peek() {
        if(IsEmpty()) {
            Console.WriteLine("Empty!");
            return 0;
        }
        return front.Data;
    }

    public bool IsEmpty() {
        return count == 0;
    }

    public int Size()
    {
        return count;
    }
}