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

        public void InsertInMiddle(int data)
        {
            SLLNode sLLNode = new SLLNode(data);
            if (Head == null)
            {
                Head = sLLNode;
            }
            else
            {
                SLLNode slowPointer = Head;
                SLLNode fastPointer = Head;

                while (fastPointer != null && fastPointer.Next != null)
                {
                    fastPointer = fastPointer.Next.Next;
                    if (fastPointer != null)
                    {
                        slowPointer = slowPointer.Next;
                    }
                }

                sLLNode.Next = slowPointer.Next;
                slowPointer.Next = sLLNode;
            }

        }

        public void InsertAtPosition(int data, int position)
        {
            SLLNode newNode = new SLLNode(data);

            if (position <= 0)
            {
                Console.WriteLine("Invalid position. Position should be greater than 0.");
                return;
            }

            if (position == 1)
            {
                newNode.Next = Head;
                Head = newNode;
                return;
            }

            SLLNode current = Head;
            int currentPosition = 1;

            while (currentPosition < position - 1 && current != null)
            {
                current = current.Next;
                currentPosition++;
            }

            if (current == null)
            {
                Console.WriteLine("Position exceeds the length of the linked list.");
                return;
            }

            newNode.Next = current.Next;
            current.Next = newNode;
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
