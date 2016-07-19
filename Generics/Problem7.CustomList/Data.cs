using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem7.CustomList
{
    public class Data<T> where T : IComparable<T>
    {
        private List<T> container;

        public Data()
        {
            this.container = new List<T>();
        }

        public List<T> Container => container;

        public void Add(T element)
        {
            this.container.Add(element);
        }

        public void Remove(int index)
        {
            this.container.RemoveAt(index);
        }

        public bool Contains(T element)
        {
            return this.container.Contains(element);
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            var firstParameter = this.container[firstIndex];
            var secondParameter = this.container[secondIndex];
            this.container[firstIndex] = secondParameter;
            this.container[secondIndex] = firstParameter;
        }

        public int CounterGreaterThan(T element)
        {
            return this.container.Count(c => c.CompareTo(element) > 0);
        }

        public T Max()
        {
            return this.container.Max();
        }

        public T Min()
        {
            return this.container.Min();
        }
    }
}