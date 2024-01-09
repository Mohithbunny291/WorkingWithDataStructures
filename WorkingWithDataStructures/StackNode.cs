namespace WorkingWithDataStructures
{
    internal class StackNode
    {
        public int Data { get; set; }
        public StackNode Next { get; set; }

        public StackNode(int data)
        {
            Data = data;
            Next = null;
        }
    }
}
