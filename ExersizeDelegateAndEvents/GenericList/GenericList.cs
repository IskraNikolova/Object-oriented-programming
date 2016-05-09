namespace GenericList
{
    using System;
    using System.Linq;

    public class GenericList<T> where T : IComparable
    {
        private const int DefaultCapacity = 16;

        private int capacity;
        private int index;
        private T[] array;

        public GenericList(int capacity = DefaultCapacity)
        {
            this.Capacity = capacity;
            this.index = 0;
            this.array = new T[capacity];
        }

        public int Capacity { get; set; }

        public T this[int position]
        {
            get
            {
                Validate(position, this.index - 1);

                return this.array[position];
            }

            set
            {
                Validate(position, this.index - 1);

                this.array[position] = value;
            }
        }

        public int Length
        {
            get { return this.index; }
        }

        public void Add(T item)
        {
            this.array[index] = item;
            index++;
        }

        public void Remove(int removingIndex)
        {
            Validate(removingIndex, this.index);
            this.array[removingIndex] = default(T);
            for (int i = removingIndex; i < this.index; i++)
            {
                this.array[i] = this.array[i + 1];
            }

            index--;
        }

        public void Insert(T item, int position)
        {
            Validate(position, this.index);
            for (int i = position; i < index + 1; i++)
            {
                this.array[position + 1] = this.array[position];
            }

            this.array[position] = item;
            index++;
        }

        public void Clear()
        {
            this.array = new T[this.capacity];
            this.index = 0;
        }

        public int FindIndex(T item)
        {
            int searchingIndex = -1;
            for (int i = 0; i < this.index; i++)
            {
                bool isEqual = item.CompareTo(this.array[i]) == 0;
                if (isEqual)
                {
                    searchingIndex = i;
                }
            }

            return searchingIndex;
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < this.index; i++)
            {
                if (item.CompareTo(this.array[i]) == 0)
                {
                    return true;
                }
            }

            return false;
        }

        private void Validate(int position, int currentPosition)
        {
            if (position > currentPosition)
            {
                throw new ArgumentOutOfRangeException(nameof(position), "Index is out of range.");
            }
        }

        public override string ToString()
        {
            var newArray = this.array.Take(this.index);
            return string.Join(" ", newArray);
        }
    }
}