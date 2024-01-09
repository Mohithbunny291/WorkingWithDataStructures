using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WorkingWithDataStructures
{
    internal class DLLNode
    {
        public int Data { get; set; }
        public DLLNode Next { get; set; }
        public DLLNode Previous { get; set; }

        public DLLNode(int data)
        {
            Data = data;
            Next = null;
            Previous = null;
        }
    }
}
