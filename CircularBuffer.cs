namespace Generic
{
    class CircularBuffer<T>
    {
        T[] _buffer;
        int _start;
        int _end;
        int capacity;

        public int Capacity { get => _buffer.Length; set => capacity = value; }
        public bool IsEmpty { get => _end == _start; }
        public bool IsFull { get => (_end + 1) % _buffer.Length == _start; }
        public CircularBuffer() : this(10)
        {
            System.Console.WriteLine("hi");
        }
        public CircularBuffer(int capacity)
        {
            _buffer = new T[capacity + 1];
            _start = 0;
            _end = 0;
        }



        public void Write(T value)
        {
            _buffer[_end] = value;
            _end = (_end + 1) % _buffer.Length;
            if (_end == _start)
            {
                _start = (_start + 1) % _buffer.Length;
            }

        }

        public T Read()
        {
            var result = _buffer[_start];
            _start = (_start + 1) % _buffer.Length;
            return result;
        }
    }
}
