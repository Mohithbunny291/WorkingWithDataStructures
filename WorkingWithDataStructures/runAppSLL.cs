using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithDataStructures
{
    internal class runAppSLL
    {
        public runAppSLL()
        {
            SingleLinkedList linkedList = new SingleLinkedList();

            // Inserting elements at the beginning of the list
            linkedList.InsertAtBeginning(3);
            linkedList.InsertAtBeginning(2);
            linkedList.InsertAtBeginning(1);
            Console.WriteLine("Enter an element to insert at the beginning of SLL");
            //int ele = int.Parse(Console.ReadLine());
            //linkedList.InsertAtBeginning(ele);
            //Console.WriteLine("Enter an element to insert at the beginning of SLL");
            int ele2 = int.Parse(Console.ReadLine());
            linkedList.InsertInMiddle(ele2);
            
            int item = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());
            linkedList.InsertAtPosition(item, position);

            // Display the linked list
            Console.WriteLine("Linked List elements:");
            linkedList.DisplayList();
        }
    }
}
