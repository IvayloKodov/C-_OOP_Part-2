using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Stack
{
    class Startup
    {
        static void Main()
        {
            Stack<int> myStack = new Stack<int>();

            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] commandInfo = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                switch (commandInfo[0])
                {
                    case "Push":
                        for (int i = 1; i < commandInfo.Length; i++)
                        {
                            myStack.Push(int.Parse(commandInfo[i]));
                        }
                        break;
                    case "Pop":
                        try
                        {
                            myStack.Pop();
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                }
                input = Console.ReadLine();
            }

            foreach (var element in myStack)
            {
                Console.WriteLine(element);
            }

            foreach (var element in myStack)
            {
                Console.WriteLine(element);
            }
        }
    }
}