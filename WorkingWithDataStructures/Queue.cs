using System;

namespace WorkingWithDataStructures
{
    internal class Queue
    {
        private QueueNode front;
        private QueueNode rear;

        public Queue()
        {
            front = rear = null;
        }

        public void Enqueue(int data)
        {
            QueueNode newQueueNode = new QueueNode(data);

            if (rear == null)
            {
                front = rear = newQueueNode;
            }
            else
            {
                rear.Next = newQueueNode;
                rear = newQueueNode;
            }
        }

        public int Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            int data = front.Data;
            front = front.Next;

            if (front == null)
            {
                rear = null;
            }

            return data;
        }

        public bool IsEmpty()
        {
            return front == null;
        }

        public void DisplayQueue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty.");
                return;
            }

            QueueNode current = front;
            Console.Write("Queue elements: ");
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}
