﻿namespace Problem2.GenericBoxOfString
{
    public class Box<T>
    {
        private readonly T item;

        public Box(T item)
        {
            this.item = item;
        }

        public override string ToString()
        {
            return $"{item.GetType().FullName}: {this.item}";
        }
    }
}