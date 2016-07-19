using System.Collections.Generic;

namespace Problem9.CollectionHierarchy
{
    public abstract class MainList<T>
    {
        private List<T> list;

        public MainList()
        {
            this.list = new List<T>();
        }

        public List<T> List
        {
            get { return list; }
        }

        public virtual int Add(T element)
        {
            this.List.Insert(0, element);
            return 0;
        }
    }
}