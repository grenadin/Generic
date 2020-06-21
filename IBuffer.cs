﻿namespace Generic
{
    interface IBuffer<T>
    {
        bool IsEmpty { get; }

        T Read();
        void Write(T value);
    }
}