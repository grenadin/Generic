using System.Collections.Generic;
using System.Collections;
namespace Generic
{
    public interface IBuffer<T>:IEnumerable<T>
    {
        bool IsEmpty { get; }
        void Write(T value);
        T Read();

        //public IEnumerable<TOutput> MethodOut<TOutput>();
       

    }
}