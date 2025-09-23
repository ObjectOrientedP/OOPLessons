/**
Enqueue: Add an element to the end of the queue.
Dequeue: Remove an element from the front.
Peek: View the front element without removing it.
IsEmpty: Check if the queue is empty.
Size: Get the number of elements in the queue.
**/

public interface IMyQueue
{
    void Enqueue(int x);

    int Dequeue();

    int Peek();

    bool IsEmpty();

    int Size();
}