using System;

namespace ArrayClassDemo
{
    public class Array<T>
    {
        #region Private fields
        private T[] _array;
        private int _count;
        #endregion
        
        public int Length { get; private set; }

        #region Constructors
        public Array(T[] array)
        {
            _array = new T[array.Length];
            for (var i = 0; i < array.Length; i++)
                _array[i] = array[i];
            Length = array.Length;
            _count = array.Length;
        }

        public Array()
        {
            _array = System.Array.Empty<T>();
            Length = 0;
            _count = 0;
        }
        #endregion

        #region Private methods
        private void ValidateIndex(int index)
        {
            if (index < 0 || index >= _array.Length)
                throw new IndexOutOfRangeException();
        }

        private T GetValue(int index)
        {
            ValidateIndex(index);
            return _array[index];
        }

        private void SetValue(int index, T value)
        {
            ValidateIndex(index);
            _array[index]= value;
        }
        #endregion
        
        public void Insert(int index, T value)
        {
            if (index < 0 || index > Length)
                throw new IndexOutOfRangeException();
            if (Length < _count)
            {
                for (var i = _array.Length; i > index; i--)
                    _array[i] = _array[i - 1];
                _array[index] = value;
            }
            else
            {
                var copy = new T[2 * (Length==0 ? 1 : Length)];
                _count = 2 * (Length==0 ? 1 : Length);
                for (var i = 0; i < index; i++)
                    copy[i] = _array[i];
                for (var i = index + 1; i <= Length; i++)
                    copy[i] = _array[i - 1];
                _array = copy;
            }
            Length++;
            _array[index] = value;
        }

        public T this[int index]
        {
            get => GetValue(index);
            set => SetValue(index, value);
        }
    }
}