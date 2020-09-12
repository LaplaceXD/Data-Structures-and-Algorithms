using System;

namespace Data_Structures_and_Algorithms.DataStructures.Arrays
{
    class ArrayCopy
    {
        private int[] _array;

        public ArrayCopy(int size)
        {
            _array = new int[size];
        }

        public void Insert(int item)
        {
            for(var i = 0; i < _array.Length; i++)
            {
                if (_array[i] != 0) continue;
                _array[i] = item;
                return;
            }

            var buffer = new int[_array.Length + 1];
            for(var a = 0; a < _array.Length; a++)
                buffer[a] = _array[a];
        
            buffer[^1] = item;
            _array = buffer;
        }

        public void RemoveAt(int index)
        {
            if(index >= _array.Length)
                throw new ArgumentOutOfRangeException();

            var buffer = new int[_array.Length - 1];
            var a = 0;
            var b = 0;
            while(a < buffer.Length)
            {
                if(b == index) {
                    a++;
                    continue;
                }

                buffer[a] = _array[b];
                a++;
                b++;
            }

            _array = buffer;
        }

        public int IndexOf(int item)
        {
            for(var i = 0; i < _array.Length; i++)
            {
                if(_array[i] == item) return i;
                i++;
            }

            return -1;
        }

        public void Print()
        {
            foreach(var num in _array) Console.WriteLine(num);
        }
    }
}