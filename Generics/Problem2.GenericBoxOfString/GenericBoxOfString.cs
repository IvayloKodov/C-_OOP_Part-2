using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2.GenericBoxOfString
{
    class GenericBoxOfString
    {
        static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();
                Console.WriteLine(new Box<int>(int.Parse(input)));
            }
        }
    }
}
