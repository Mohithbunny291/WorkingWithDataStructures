using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WorkingWithDataStructures
{
    internal class DoubleLinkedList
    {
        public DLLNode Head { get; set; }
        public DLLNode Tail { get; set; }

        public DoubleLinkedList()
        {
            Head = null;
            Tail = null;
        }

        public void InsertAtEnd(int data)
        {
            DLLNode newDLLNode = new DLLNode(data);

            if (Head == null)
            {
                Head = Tail = newDLLNode;
            }
            else
            {
                Tail.Next = newDLLNode;
                newDLLNode.Previous = Tail;
                Tail = newDLLNode;
            }
        }

        public void DisplayList()
        {
            DLLNode current = Head;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}
