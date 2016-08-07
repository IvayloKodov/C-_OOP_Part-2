using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem2.Collection
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
                string command = Console.ReadLine();

                while (command != "END")
                {
                    switch (command)
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
                        case "PrintAll":
                            foreach (var element in myList)
                            {
                                Console.Write(element+" ");
                            }
                            Console.WriteLine();
                            break; 
                    }
                    command = Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}