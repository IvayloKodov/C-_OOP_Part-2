using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Problem1.GenericBox
{
    public class Startup
    {
        public static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();

                int number;
                var isNumber = Int32.TryParse(input, out number);

                if (isNumber)
                {
                    var boxInt = new Box<int>(number);
                    Console.WriteLine(boxInt);
                }
                else
                {
                    var boxString = new Box<string>(input);
                    Console.WriteLine(boxString);
                }
            }
        }
    }
}
