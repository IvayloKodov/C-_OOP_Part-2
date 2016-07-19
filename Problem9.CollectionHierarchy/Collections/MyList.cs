using System.Collections.Generic;

namespace Problem9.CollectionHierarchy
{
    public class MyList<T> :MainList<T>,IRemovable<T>
    {
        private int used;

        public MyList()
        {
        }

        public int Used
        {
            get { return base.List.Count-1; }
        }

        public T Remove()
        {
            var firstElement = base.List[0];
            base.List.RemoveAt(0);
            return firstElement;
        }
    }
}