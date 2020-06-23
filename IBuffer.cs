using System.Collections.Generic;

namespace Generic
{
    interface IBuffer<T>:IEnumerable<T>
    {
        bool IsEmpty { get; }

        T Read();
        void Write(T value);
    }
}