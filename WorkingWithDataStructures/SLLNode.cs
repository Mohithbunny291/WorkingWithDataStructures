using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WorkingWithDataStructures
{
    internal class SLLNode
    {
        public int Data { get; set; }
        public SLLNode Next { get; set; }

        public SLLNode(int data)
        {
            Data = data;
            Next = null;
        }
    }
}
