using System.Dynamic;

namespace Problem9.CustomListTraversal
{
    public interface IMyCustomList<T>
    {
        void Add(T element);
        bool Remove(T element);
        int Count { get; }
    }
}