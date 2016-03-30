using System.Collections;

namespace Problem3GenericList
{
    using System;
    using System.Text;

    [Version(2, 11)]
    public class GenericList<T> 
        where T : IComparable<T>
    {
        private const int DefaultCapacity = 16;
        private T[] array;
        private int index;
        private int currentCapacity;

        public GenericList(int capacity = DefaultCapacity)
        {
            this.array = new T[capacity];
            this.index = 0;
            this.currentCapacity = capacity;
        }

        public int Length
        {
            get
            {
                return this.index;
            }
        }

        public T this[int position]
        {
            get
            {
                this.ValidateIndex(position);
                return this.array[position];
            }

            set
            {
                if (position >= this.index)
                {
                    this.index++;
                }

                this.array[position] = value;
            }
        }

        public void Add(T item)
        {
            this.array[this.index] = item;
            this.index++;
            if (this.index == this.currentCapacity)
            {
                this.Resize(this.index * 2);
            }
        }

        public void Remove(int indexToRemove)
        {
            this.ValidateIndex(indexToRemove);

            this.array[indexToRemove] = default(T);
            for (int i = indexToRemove; i < this.array.Length - 1; i++)
            {
                this.array[i] = this.array[i + 1];
            }

            this.index--;
        }

        public void Insert(int indexToInsert, T item)
        {
            this.ValidateIndex(indexToInsert);
            T[] arrayCopy = new T[this.currentCapacity];
            for (int i = 0; i < this.currentCapacity; i++)
            {
                arrayCopy[i] = this.array[i];
            }

            for (int i = indexToInsert + 1; i < this.array.Length; i++)
            {
                T newValue = arrayCopy[i - 1];
                this.array[i] = newValue;
            }

            this.array[indexToInsert] = item;
            this.index++;

            if (this.index == this.currentCapacity)
            {
                this.Resize(this.index * 2);
            }
        }

        public void Clear()
        {
            for (int i = 0; i < this.index; i++)
            {
                this.array[i] = default(T);
            }

            this.index = 0;
        }

        public int IndexOf(T item)
        {
            int searchIndex = -1;

            for (int i = 0; i < this.index; i++)
            {
                if (item.Equals(this.array[i]))
                {
                    searchIndex = i;
                }
            }

            return searchIndex;
        }

        public T Min()
        {
            T min = this.array[0];
            for (int i = 1; i < this.index; i++)
            {
                T currentElement = this.array[i];
                if (currentElement.CompareTo(min) < 0)
                {
                    min = currentElement;
                }
            }

            return min;
        }

        public T Max()
        {
            T max = this.array[0];
            for (int i = 1; i < this.index; i++)
            {
                T currentElement = this.array[i];
                if (currentElement.CompareTo(max) > 0)
                {
                    max = currentElement;
                }
            }

            return max;
        }

        public override string ToString()
        {
            StringBuilder resultBuilder = new StringBuilder();
            if (this.index > 0)
            {
                for (int i = 0; i < this.index; i++)
                {
                    resultBuilder.AppendLine(this.array[i].ToString());
                }

                return resultBuilder.ToString().TrimEnd();
            }

            return string.Empty;
        }

        public bool Contains(T item)
        {
            bool isContains = false;

            for (int i = 0; i < this.index; i++)
            {
                if (this.array[i].Equals(item))
                {
                    isContains = true;
                }
            }

            return isContains;
        }

        public void Reverse()
        {
            T[] reverseArray = new T[this.currentCapacity];
            for (int i = this.index - 1; i >= 0; i--)
            {
                reverseArray[i] = this.array[i];
            }

            this.array = reverseArray;
        }

        public string Version()
        {
            var version = string.Empty;
            var type = typeof(GenericList<T>);
            var attributes = type.GetCustomAttributes(false);
            foreach (var attribute in attributes)
            {
                var currentAttribute = attribute as Version;
                if (currentAttribute != null)
                {
                    var versionAttribute = currentAttribute;
                    version = $"GenericList<T> version {versionAttribute.Major}.{versionAttribute.Minor}";
                }
            }

            return version;
        }

        private void ValidateIndex(int validateIndex)
        {
            if (validateIndex < 0 || validateIndex > this.index - 1)
            {
                throw new ArgumentOutOfRangeException(nameof(validateIndex), "Index is out of range.");
            }
        }

        private void Resize(int newCapacity)
        {
            T[] newArray = new T[newCapacity];

            for (int i = 0; i < this.array.Length; i++)
            {
                newArray[i] = this.array[i];
            }

            this.array = newArray;
            this.currentCapacity = newCapacity;
        }
    }
}