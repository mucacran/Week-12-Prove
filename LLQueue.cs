namespace Week_12_Prove;

public class QueueException : Exception
{
    public QueueException(string message) : base(message) { }
}



public class Queue<T>
{
    private LinkedList<T> _list;

    public Queue()
    {
        _list = new LinkedList<T>();
    }

    /// <summary>
    /// Adds a new node at the back (i.e. the tail) of the linked list.
    /// </summary>
    public void Enqueue(T value)
    {
        //Create new node
        _list.AddLast(value);
    }

    /// <summary>
    /// Removes and returns the front item of the queue.
    /// </summary>
    public T Dequeue()
    {
        if (_list.Count == 0)
            throw new QueueException("Queue is empty");
        T value = _list.First!.Value;
        _list.RemoveFirst();
        return value;
    }

    /// <summary>
    /// Returns the front item without removing it.
    /// </summary>
    public T Peek()
    {
        if (_list.Count == 0)
            throw new QueueException("Queue is empty");
        return _list.First!.Value;
    }
}