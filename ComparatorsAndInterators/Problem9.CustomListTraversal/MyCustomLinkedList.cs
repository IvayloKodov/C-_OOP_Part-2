using System;
using System.Collections;
using System.Collections.Generic;

namespace Problem9.CustomListTraversal
{
    public class MyCustomLinkedList<T> : IMyCustomList<T>, IEnumerable<Node<T>> where T : IComparable<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public void Add(T element)
        {
            if (this.Count == 0)
            {
                head = new Node<T>(element);
            }
            else if (this.Count == 1)
            {
                tail = new Node<T>(element);
                head.Next = tail;
                tail.Previous = head;
            }
            else
            {
                var current = new Node<T>(element);
                tail.Next = current;
                current.Previous = tail;
                tail = current;
            }
            this.Count++;
        }

        public bool Remove(T element)
        {
            foreach (var item in this)
            {
                var current = item;

                if (current.Value.CompareTo(element) == 0)
                {
                    if (current.Previous == null && current.Next == null)
                    {
                        head = null;
                        this.Count--;
                        return true;
                    }

                    if (current.Previous == null)
                    {
                        head = current.Next;
                        current.Next.Previous = null;
                        current.Next = null;
                        this.Count--;
                        return true;
                    }

                    current.Previous.Next = current.Next;
                    current.Next.Previous = current.Previous;
                    current.Next = null;
                    current.Previous = null;
                    this.Count--;
                    return true;
                }
            }
            return false;
        }

        public int Count { get; private set; }

        public IEnumerator<Node<T>> GetEnumerator()
        {
            var current = head;
            while (current != null)
            {
                yield return current;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}