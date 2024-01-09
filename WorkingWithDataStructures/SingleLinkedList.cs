using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WorkingWithDataStructures
{
    internal class SingleLinkedList
    {
        public SLLNode Head { get; set; }

        public SingleLinkedList()
        {
            Head = null;
        }

        public void InsertAtBeginning(int data)
        {
            SLLNode newSLLNode = new SLLNode(data);
            newSLLNode.Next = Head;
            Head = newSLLNode;
        }

        public void DisplayList()
        {
            SLLNode current = Head;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}
