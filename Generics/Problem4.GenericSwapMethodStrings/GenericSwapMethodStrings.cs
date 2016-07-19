using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem4.GenericSwapMethodStrings
{
    class GenericSwapMethodStrings
    {
        static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            var boxList = new List<Box<string>>();
            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();
                boxList.Add(new Box<string>(input));
            }
            int[] swapIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            SwapList(boxList, swapIndexes[0], swapIndexes[1]);

            boxList.ForEach(Console.WriteLine);
        }

        public static void SwapList<T>(List<T> collection, int firstPosition, int secondPosition)
        {
            T firstSwapped = collection[firstPosition];
            T secondSwapped = collection[secondPosition];

            collection[firstPosition] = secondSwapped;
            collection[secondPosition] = firstSwapped;
        }
    }
}