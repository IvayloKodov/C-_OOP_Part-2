using System;
using System.Collections;
using System.Collections.Generic;

namespace Problem1.ListIterator
{
    public class ListyIterator<T> 
    {
        private List<T> list;
        private int index;

        public ListyIterator(List<T> list)
        {
            this.List = list;
            this.index = 0;
        }

        public List<T> List
        {
            get { return list; }
            set
            {
                if (value.Count==0)
                {
                    throw new InvalidOperationException("Invalid Operation!");
                }

                this.list = value;
            }
        }

        public T Print()
        {
            return this.list[this.index];
        }

        public bool Move()
        {
            if (this.HasNext())
            {
                this.index++;
                return true;
            }
            return false;
        }

        public bool HasNext() => this.index+1 < this.list.Count;
    }
}