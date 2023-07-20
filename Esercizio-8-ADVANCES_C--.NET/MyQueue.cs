using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_8_ADVANCES_C__.NET
{
    public class MyQueue<T> : IEnqueue<T>, IDequeue<T>, IPeek<T>
    {

        public Queue<T> queue = new Queue<T>();

        public T Dequeue()
        {
            if (queue == null)
                throw new NotImplementedException();
            return queue.Dequeue();
        }

        public T Enqueue(T item)
        {
           queue.Enqueue(item); return item;
        }

        public  T Peek()
        {
            if (queue.Count == 0)
                throw new InvalidOperationException("The queue is empty.");
            return queue.Peek();
        }
    }
}
