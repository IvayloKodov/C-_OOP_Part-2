using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem5.GenericCountMethodStrings
{
    public class GenericCountMethodStrings
    {
        public static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            var boxList = new List<Box<double>>();
            for (int i = 0; i < lines; i++)
            {
                double input = double.Parse(Console.ReadLine());
                boxList.Add(new Box<double>(input));
            }

            double comparingValue = double.Parse(Console.ReadLine());
            var result = CountGreaterElements(boxList, comparingValue);
            Console.WriteLine(result);
        }

        public static int CountGreaterElements<T>(List<Box<T>> collection, T value)
                        where T : IComparable<T>
        {
            return collection.Count(c => c.Item.CompareTo(value) > 0);
        }
    }
}
