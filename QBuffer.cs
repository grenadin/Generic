
using System.Collections.Generic;
namespace Generic
{
    class QBuffer<T> : IBuffer<T>
    {
        Queue<T> queue = new Queue<T>();
        public bool IsEmpty  { get => queue.Count == 0; }

        public T Read() => queue.Dequeue();


        public void Write(T value) => queue.Enqueue(value);
        
    }




}
