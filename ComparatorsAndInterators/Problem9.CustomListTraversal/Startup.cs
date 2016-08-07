using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem9.CustomListTraversal
{
    class Startup
    {
        static void Main()
        {
            var myList = new MyCustomLinkedList<int>();
            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                string []commandInfo = Console.ReadLine().Split();
                switch (commandInfo[0])
                {
                    case "Add":
                        myList.Add(int.Parse(commandInfo[1]));
                        break;
                    case "Remove":
                        myList.Remove(int.Parse(commandInfo[1]));
                        break;
                }
            }
            Console.WriteLine(myList.Count);
            Console.WriteLine(string.Join(" ", myList));
        }
    }
}