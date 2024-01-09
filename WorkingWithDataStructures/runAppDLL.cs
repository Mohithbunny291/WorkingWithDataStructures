using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithDataStructures
{
    internal class runAppDLL
    {
        public runAppDLL()
        {
            // Demonstrate doubly linked list

            DoubleLinkedList doublyLinkedList = new DoubleLinkedList();

            // Inserting elements at the end of the list
            doublyLinkedList.InsertAtEnd(1);
            doublyLinkedList.InsertAtEnd(2);
            doublyLinkedList.InsertAtEnd(3);

            // Display the doubly linked list
            Console.WriteLine("Doubly Linked List elements:");
            doublyLinkedList.DisplayList();
        }
    }
}
