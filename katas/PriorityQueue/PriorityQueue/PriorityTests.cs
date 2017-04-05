using Xunit;

namespace PriorityQueue
{
    public class PriorityQueueTests
    {
        [Fact]
        public void Should_test()
        {
            var priorityQueue = new PriorityQueue<Item>();
            priorityQueue.Enqueue(new Item(1), 1);
            priorityQueue.Enqueue(new Item(2), 2);
        }
    }
}