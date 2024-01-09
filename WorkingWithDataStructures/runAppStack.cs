using System;

namespace WorkingWithDataStructures
{
    internal class runAppStack
    {
        public runAppStack()
        {
            // Demonstrate stack using linked list

            Stack stack = new Stack();

            // Push elements onto the stack
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            // Display the stack
            stack.DisplayStack();

            // Pop an element from the stack
            int poppedElement = stack.Pop();
            Console.WriteLine($"Popped element: {poppedElement}");

            // Display the stack after popping
            stack.DisplayStack();
        }
    }
}
