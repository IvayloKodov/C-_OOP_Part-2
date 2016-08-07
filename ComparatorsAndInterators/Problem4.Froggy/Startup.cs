using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4.Froggy
{
    class Startup
    {
        static void Main()
        {
            int[] stoneNumbers =
                Console.ReadLine()
                    .Split(new char[] {' ',','}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            List<Stone> stones = new List<Stone>();
            for (int i = 0; i < stoneNumbers.Length; i++)
            {
                stones.Add(new Stone(stoneNumbers[i]));
            }

            Lake<Stone> lake = new Lake<Stone>(stones);

            int counter = 0;
            foreach (var stone in lake)
            {
                if (counter==stoneNumbers.Length-1)
                {
                    Console.Write(stone.NumberOfStone);
                    break;
                }
                Console.Write(stone.NumberOfStone+", ");
                counter ++;
            }
            Console.WriteLine();
        }
    }
}
