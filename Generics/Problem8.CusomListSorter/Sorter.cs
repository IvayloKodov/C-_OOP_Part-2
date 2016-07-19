using System;
using System.Collections.Generic;

namespace Problem8.CusomListSorter
{
    public class Sorter
    {
        public static void Sort<T>(List<T> customList) where T : IComparable<T>
        {
           customList.Sort((x,y)=> x.CompareTo(y));
        }
    }
}