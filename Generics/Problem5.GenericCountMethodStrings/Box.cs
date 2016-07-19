using System;

namespace Problem5.GenericCountMethodStrings
{
    public class Box<T> where T : IComparable<T>
    {
        private readonly T item;

        public Box(T item)
        {
            this.item = item;
        }

        public T Item
        {
            get { return item; }
        }

        public override string ToString()
        {
            return $"{item.GetType().FullName}: {this.item}";
        }
    }
}