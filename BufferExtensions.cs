using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Generic
{
     
    public static class BufferExtensions
    {
       
        public static void Dump<T>(this IBuffer<T> buffer, Action<T> del)
        {
            foreach (var item in buffer)
            {
                del(item);
            }
        }
        public static IEnumerable<TOutput> AsEnum<T,TOutput>(this IBuffer<T> buffer)

        {
            var converter = TypeDescriptor.GetConverter(typeof(T));
            foreach (var item in buffer)
            {
                TOutput result = (TOutput)converter.ConvertTo(item, typeof(TOutput));
                yield return result;
            }
        }

        
        


        public static IEnumerable<TOutput> Map<T, TOutput>
           (this IBuffer<T> buffer,Converter<T,TOutput> converter)
        {

            return buffer.Select(i => converter(i));
        }

    }
}
