namespace WorkingWithDataStructures
{
    internal class QueueNode
    {
        public int Data { get; set; }
        public QueueNode Next { get; set; }

        public QueueNode(int data)
        {
            Data = data;
            Next = null;
        }
    }
}
