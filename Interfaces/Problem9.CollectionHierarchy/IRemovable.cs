using System.Runtime.InteropServices.ComTypes;

namespace Problem9.CollectionHierarchy
{
    public interface IRemovable<T>
    {
        T Remove();
    }
}