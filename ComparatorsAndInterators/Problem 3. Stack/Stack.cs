using System;
using System.Collections;
using System.Collections.Generic;

namespace Problem_3.Stack
{
    public class Stack <T> : IEnumerable<T>
    {
        private List<T> stackCollection;

        public Stack()
        {
        }

        public void Push(T element)
        {
            if (this.stackCollection==null)
            {
                this.stackCollection=new List<T>();
            }

            this.stackCollection.Add(element);
        }

        public void Pop()
        {
            if (this.stackCollection.Count>0)
            {
                this.stackCollection.RemoveAt(this.stackCollection.Count-1);
            }
            else
            {
                throw new InvalidOperationException("No elements");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.stackCollection.Count-1; i >=0; i--)
            {
                yield return this.stackCollection[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}