/*
 * CSE212 
 * (c) BYU-Idaho
 * Week 12 Prove
 * 
Implement a generic Queue<T> class using a Linked List.
Ensure the implementation meets all functional and performance requirements through test cases.
Measure and analyze the performance of the queue operations.
 */

using Week_12_Prove;


Console.WriteLine("Week 12 Prove: Final Project - LinkedList Queue");

//LLQueueTests.Run();
//LLQueuePerformance.Run();

LLQueue<int> queue = new LLQueue<int>();
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
queue.Enqueue(4);
queue.Enqueue(5);
queue.Enqueue(6);
queue.Enqueue(7);
queue.Enqueue(8);
queue.Enqueue(9);
queue.Enqueue(10);

Console.WriteLine("Queue after enqueueing 10 elements:");

Console.WriteLine($"Front item: {queue.Peek()}");
Console.WriteLine($"Contains 5: {queue.Contains(5)}");
Console.WriteLine($"Contains 11: {queue.Contains(11)}");
Console.WriteLine($"Size of queue: {queue.Size}");
Console.WriteLine($"Queue is empty: {queue.IsEmpty}");


//presentar todos los elementos de la lista
Console.WriteLine("Dequeueing elements:");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(queue.Dequeue());
}
Console.WriteLine("Queue after dequeueing all elements:");

