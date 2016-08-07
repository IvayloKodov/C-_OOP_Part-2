using System;

namespace Problem9.CustomListTraversal
{
    public class Node<T> 
    {
        private T value;
        private Node<T> previous;
        private Node<T> next;

        public Node(T value)
        {
            this.Value = value;
        }

        public T Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        public Node<T> Previous
        {
            get { return this.previous; }
            set { this.previous = value; }
        }

        public Node<T> Next
        {
            get { return this.next; }
            set { this.next = value; }
        }

        public override string ToString()
        {
            return $"{this.Value}";
        }
    }
}