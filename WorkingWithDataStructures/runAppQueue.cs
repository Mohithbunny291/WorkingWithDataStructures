using System;

namespace WorkingWithDataStructures
{
    internal class runAppQueue
    {
        public runAppQueue()
        {
            // Demonstrate queue

            Queue queue = new Queue();

            // Enqueue elements into the queue
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            // Display the queue
            queue.DisplayQueue();

            // Dequeue an element from the queue
            int dequeuedElement = queue.Dequeue();
            Console.WriteLine($"Dequeued element: {dequeuedElement}");

            // Display the queue after dequeuing
            queue.DisplayQueue();
        }
    }
}
