namespace LambdaCore_Skeleton.Interfaces
{
    public interface IListStack<T>
    {
        int Count();

        T Push(T item);

        void Pop();

        T Peek();

        bool IsEmpty();
    }
}