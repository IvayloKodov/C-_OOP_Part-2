using System;

namespace Problem1.EventImplementation
{
    public class Handler
    {
        public void OnDispatcherNameChange(object sender, NameChangeEventArgs args)
        {
            Console.WriteLine("Dispatcher's name changed to {0}.", args.Name);
        }
    }
}