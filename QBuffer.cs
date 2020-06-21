using System.Collections.Generic;

namespace Generic
{
    public class QBuffer<T> : IBuffer<T>
    {
        Queue<T> _queue = new Queue<T>();
        public bool IsEmpty => _queue.Count == 0;

        public T Read() => _queue.Dequeue();
        

        public void Write(T value) => _queue.Enqueue(value);
        
    }
}
