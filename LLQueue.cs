namespace Week_12_Prove;
using System.Collections.Generic;

public class QueueException : Exception
{
    public QueueException(string message) : base(message) { }
}

public class Node
{
    public int Data { get; set; }
    public Node? Next { get; set; }
    public Node? Prev { get; set; }

    public Node(int data)
    {
        this.Data = data;
    }
}

public class LLQueue
{
    private LinkedList<T> _list;
    private Node? head;
    private Node? tail;
    private int count;

    public LLQueue()
    {
        head = null;
        tail = null;
        count = 0;
    }

    public void Enqueue(int data)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail!.Next = newNode; // Use the null-forgiving operator to avoid warning
            newNode.Prev = tail;
            tail = newNode;
        }
        count++;
    }
}