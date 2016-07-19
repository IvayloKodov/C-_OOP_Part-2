using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem9.CollectionHierarchy
{
    class Startup
    {
        static void Main()
        {
            string[] elements = Console.ReadLine().Split(new char[] { });
            var addCollection = new AddCollection<string>();
            var addRemoveCollection = new AddRemoveCollection<string>();
            var myListCollection = new MyList<string>();

            for (int i = 0; i < elements.Length; i++)
            {
                Console.Write(addCollection.Add(elements[i]) + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < elements.Length; i++)
            {
                Console.Write(addRemoveCollection.Add(elements[i]) + " ");

            }
            Console.WriteLine();
            for (int i = 0; i < elements.Length; i++)
            {
                Console.Write(myListCollection.Add(elements[i]) + " ");
            }
            Console.WriteLine();


            int removeCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < removeCount; i++)
            {
                Console.Write(addRemoveCollection.Remove()+" ");
            }
            Console.WriteLine();
            for (int i = 0; i < removeCount; i++)
            {
                Console.Write(myListCollection.Remove() + " ");
            }
            Console.WriteLine();
        }
    }
}
