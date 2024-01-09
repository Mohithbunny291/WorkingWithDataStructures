using System;

namespace WorkingWithDataStructures
{
    internal class Stack
    {
        private StackNode top;

        public Stack()
        {
            top = null;
        }

        public void Push(int data)
        {
            StackNode newStackNode = new StackNode(data);
            newStackNode.Next = top;
            top = newStackNode;
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            int data = top.Data;
            top = top.Next;
            return data;
        }

        public bool IsEmpty()
        {
            return top == null;
        }

        public void DisplayStack()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty.");
                return;
            }

            StackNode current = top;
            Console.Write("Stack elements: ");
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}
