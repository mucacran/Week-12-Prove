﻿/*
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

LLQueue<T> queue = new LLQueue<T>();
queue.Enqueue("100");
queue.Enqueue("mama");
queue.Enqueue("30");
queue.Enqueue("4");
queue.Enqueue("785");


Console.WriteLine("Queue after enqueueing 10 elements:");

Console.WriteLine($"Front item: {queue.Peek()}");
Console.WriteLine($"Contains 5: {queue.Contains(5)}");
Console.WriteLine($"Contains 11: {queue.Contains(11)}");
Console.WriteLine($"Size of queue: {queue.Size}");
Console.WriteLine($"Queue is empty: {queue.IsEmpty}");


//presentar todos los elementos de la lista
foreach (var item in queue.ToList())
{
    Console.WriteLine(item);
}

Console.WriteLine("Queue after dequeueing all elements:");

