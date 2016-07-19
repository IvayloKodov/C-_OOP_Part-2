using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8.CusomListSorter
{
    class Startup
    {
        static void Main()
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                CommandInterpreter.Interpreter(input);
                input = Console.ReadLine();
            }
        }
    }
}
