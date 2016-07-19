using System;

namespace Problem7.CustomList
{
    class Startup
    {
        static void Main()
        {
            string input = Console.ReadLine();
            while (input!="END")
            {
                CommandInterpreter.Interpreter(input);
                input = Console.ReadLine();
            }
        }
    }
}