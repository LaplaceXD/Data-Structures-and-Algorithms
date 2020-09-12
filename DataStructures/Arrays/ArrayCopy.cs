using System;

namespace Data_Structures_and_Algorithms.DataStructures.Arrays
{
    class ArrayCopy
    {
        private int[] _array;
        private int _count;

        public ArrayCopy(int size)
        {
            _array = new int[size];
            _count = 0;
        }

        public void Insert(int item)
        {
            if(_count < _array.Length) 
            {
                _array[_count] = item;
                _count++;
                return;
            }

            var buffer = new int[_array.Length + 1];
            for(var a = 0; a < _array.Length; a++)
                buffer[a] = _array[a];
        
            buffer[^1] = item;
            _array = buffer;
            _count++;
        }

        public void RemoveAt(int index)
        {
            if(index >= _array.Length)
                throw new ArgumentOutOfRangeException();

            var buffer = new int[_array.Length - 1];
            var a = 0;
            var b = 0;
            while(a < _array.Length)
            {
                if(a == index) {
                    a++;
                    continue;
                }

                buffer[b] = _array[a];
                a++;
                b++;
            }

            _array = buffer;
            _count--;
        }

        public int IndexOf(int item)
        {
            for(var i = 0; i < _array.Length; i++)
                if(_array[i] == item) return i;

            return -1;
        }

        public void Print()
        {
            for(var i = 0; i < _count; i++) Console.WriteLine(_array[i]);
        }
    }
}