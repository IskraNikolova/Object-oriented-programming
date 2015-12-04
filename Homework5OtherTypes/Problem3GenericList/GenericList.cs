using System;

namespace Problem3GenericList
{
    [Version(2,13213424)]
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
            this.currentCapacity = capacity;
            this.index = 0;
        }

        /// <summary>
        /// Length of collection
        /// </summary>
        public int Length
        {
            get { return this.index; }
        }

        /// <summary>
        /// Add value on the collection
        /// </summary>
        /// <param name="item">value added</param>
        public void Add(T item)
        {
            this.array[this.index] = item;
            this.index++;
            if (this.index == currentCapacity)
            {
                this.Resize(this.currentCapacity * 2);
            }
        }

        /// <summary>
        /// Remove value of the position
        /// </summary>
        /// <param name="index">Index of value</param>
        public void Remove(int index)
        {
            ValidateIndex(index);
            this.array[index] = default(T);
            for (int i = index; i < this.array.Length - 1; i++)
            {
                this.array[i] = this.array[i + 1];
            }
            this.index--;
        }

        /// <summary>
        /// Add value on index
        /// </summary>
        /// <param name="index">index of add</param>
        /// <returns>Return value of this index</returns>
        public T this[int index]
        {
            get
            {
                ValidateIndex(index);
                return this.array[index];
            }
            set
            {
                this.array[index] = value;
                this.index++;
            }
        }

        /// <summary>
        /// Insert value of index
        /// </summary>
        /// <param name="index">Index where we insert</param>
        /// <param name="value">Value for insert</param>
        public void Insert(int index, T value)
        {
            ValidateIndex(index);
            T[] arrayCopy = new T[currentCapacity];
            for (int i = 0; i < currentCapacity; i++)
            {
                arrayCopy[i] = this.array[i];
            }

            for (int i = index + 1; i < this.array.Length; i++)
            {  
                T newValue = arrayCopy[i - 1];
                this.array[i] = newValue;
            }
            this.array[index] = value;
            this.index++;
        }

        /// <summary>
        /// Clear all collection
        /// </summary>
        public void Clear()
        {
            for (int i = 0; i < currentCapacity; i++)
            {
                this.array[i] = default(T);
            }
            index = 0;
        }

        /// <summary>
        /// Find index of item
        /// </summary>
        /// <param name="item">Value</param>
        /// <returns>Index</returns>
        public int Find(T item)
        {
            int findIndex = -1;
            for (int i = 0; i < index; i++)
            {
                if (item.Equals(this.array[i]))
                {
                    findIndex = i;
                }
            }
            return findIndex;
        }

        /// <summary>
        /// Contains value of collection 
        /// </summary>
        /// <param name="item">Search value</param>
        /// <returns>False or True</returns>
        public bool Contains(T item)
        {
            bool isContains = false;
            for (int i = 0; i < index; i++)
            {
                if (item.Equals(this.array[i]))
                {
                    isContains = true;
                }
            }
            return isContains;
        }

        public override string ToString()
        {
            T[] resultaArray = new T[index];

            for (int i = 0; i < index; i++)
            {
                resultaArray[i] = this.array[i];
            }

            string result = string.Empty;

            if (resultaArray.Length > 0)
            {
                result = "[" + String.Join(", ", resultaArray) + "]";
            }
        
            return result;
        }

        /// <summary>
        /// Resize collection
        /// </summary>
        /// <param name="newCapacity">new size of capacity</param>
        private void Resize(int newCapacity)
        {
            T[] newArray = new T[newCapacity];
            for (int i = 0; i < this.index; i++)
            {
                newArray[i] = this.array[i];
                this.array = newArray;
                this.currentCapacity = newCapacity;
            }
        }

        private void ValidateIndex(int index)
        {
            if (index >= this.index || index < 0)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(index),
                    message: "Index is out of range!");
            }
        }

        public string Version()
        {
            var versionNum = string.Empty;
            var type = typeof(GenericList<T>);
            var allAttributes = type.GetCustomAttributes(false);
            foreach (var attr in allAttributes)
            {
                var attribute = attr as VersionAttribute;
                if (attribute != null)
                {
                    var version = attribute;
                    versionNum = $"GenericList<T> version {version.Major}.{version.Minor}";
                }
            }

            return versionNum;
        }
    }
}
