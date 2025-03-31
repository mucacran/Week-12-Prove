namespace Week_12_Prove;

public class QueueException : Exception
{
    public QueueException(string message) : base(message) { }
}



public class LLQueue<T>
{
    private LinkedList<T> _list;

    public LLQueue()
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

    /// <summary>
    /// Checks if the item is in the queue.
    /// </summary>
    public bool Contains(T item)
    {
        return _list.Contains(item);
    }

    /// <summary>
    /// Your queue implementation must also support a Size property that returns the number of elements in the queue.
    /// </summary>
    public int Size
    {
        get { return _list.Count; }
    }
    /// <summary>
    /// Returns true if the queue is empty.
    /// </summary>
    public bool IsEmpty()
    {
        return _list.Count == 0;
    }

    // contenido de la lista
    public List<T> ToList()
    {
        List<T> list = new List<T>();


        foreach (var item in _list)
        {
            list.Add(item);
        }   

        return list;

    }

    /// <summary>
    /// traverse a list and print the elements
    /// </summary>
    public void PrintList()
    {
        foreach (var item in _list)
        {
            Console.WriteLine(item);
        }
    }
       


}