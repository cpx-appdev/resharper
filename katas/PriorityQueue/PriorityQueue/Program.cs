namespace PriorityQueue
{
    public class Program
    {
        void Start()
        {
            var priorityQueue = new PriorityQueue<Item>();
            priorityQueue.Enqueue(new Item(1), 42);
            priorityQueue.Enqueue(new Item(2), 21);
        }
    }
}