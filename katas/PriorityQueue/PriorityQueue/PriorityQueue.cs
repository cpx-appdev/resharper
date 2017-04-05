using System.Collections.Generic;

namespace PriorityQueue
{
    public class PriorityQueue<T>
    {
        private readonly Queue<QueueElement<T>> _list;

        public PriorityQueue()
        {
            _list = new Queue<QueueElement<T>>();
        }

        public void Enqueue(T element, int priority)
        {
            var queueElement = new QueueElement<T>();
            _list.Enqueue(queueElement);
        }
    }

    class QueueElement<T>
    {
        public int Priority { get; set; }
        public T Element { get; set; }
    }
}