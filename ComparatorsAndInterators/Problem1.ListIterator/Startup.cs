using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1.ListIterator
{
    class Startup
    {
        static void Main()
        {
            List<string> createList = Console.ReadLine().Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var list = createList.GetRange(1, createList.Count - 1);
            try
            {
                var myList = new ListyIterator<string>(list);
                string input = Console.ReadLine();
                while (input != "END")
                {
                    string[] commands = input.Split();
                    switch (commands[0])
                    {
                        case "Print":
                            Console.WriteLine(myList.Print());
                            break;
                        case "Move":
                            Console.WriteLine(myList.Move());
                            break;
                        case "HasNext":
                            Console.WriteLine(myList.HasNext());
                            break;
                    }
                    input = Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
