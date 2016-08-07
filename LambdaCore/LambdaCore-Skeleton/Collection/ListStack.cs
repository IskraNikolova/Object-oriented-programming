namespace LambdaCore_Skeleton.Collection
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Interfaces;
    using Models.Cores;

    public class ListStack<T> : IListStack<T>, IEnumerable<T>
    {
        private readonly LinkedList<T> innerList;

        public ListStack()
        {
            this.innerList = new LinkedList<T>();
        }

        public int Count()
        {
            return this.innerList.Count;
        }

        public T Push(T item)
        {
            this.innerList.AddLast(item);
            return item;
        }

        public void Pop()
        {
            this.innerList.RemoveLast();
        }

        public T Peek()
        {
            var peekedItem = this.innerList.First();
            return peekedItem;
        }

        public bool IsEmpty()
        {
            return this.innerList.Count > 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.innerList.Count; i++)
            {
                yield return this.innerList.Last();
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}