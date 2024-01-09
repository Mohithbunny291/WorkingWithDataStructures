using System;

namespace WorkingWithDataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------Arrays--------------------------------------");
            new runAppArrays();

            Console.WriteLine("--------------------------Single Linked List--------------------------");
            new runAppSLL();

            Console.WriteLine("--------------------------Double Linked List--------------------------");
            new runAppDLL();

            Console.WriteLine("--------------------------Stack---------------------------------------");
            new runAppStack();

            Console.WriteLine("--------------------------Queue---------------------------------------");
            new runAppQueue();
        }
    }
}
