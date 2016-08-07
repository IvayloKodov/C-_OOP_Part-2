using System;

namespace Problem1.EventImplementation
{
    class Startup
    {
        static void Main()
        {
            Dispatcher dispatcher = new Dispatcher();
            Handler handler = new Handler();
            dispatcher.NameChanged += handler.OnDispatcherNameChange;

            string line = Console.ReadLine();
            while (line != "End")
            {
                dispatcher.Name = line;
                line = Console.ReadLine();
            }
        }
    }
}