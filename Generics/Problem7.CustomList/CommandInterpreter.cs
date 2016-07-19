using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace Problem7.CustomList
{
    public class CommandInterpreter
    {
        private static Data<string> data = new Data<string>();

        public static void Interpreter(string input)
        {
            string[] commandInfo = input.Split(new []{' '},StringSplitOptions.RemoveEmptyEntries);
            string command = commandInfo[0];

            switch (command.ToLower())
            {
                case "add":
                    string element = commandInfo[1];
                    data.Add(element);
                    break;
                case "remove":
                    int index = int.Parse(commandInfo[1]);
                    data.Remove(index);
                    break;
                case "contains":
                    string a = commandInfo[1];
                    Console.WriteLine("{0}",
                        data.Contains(a)? "True" : "False");
                    break;
                case "swap":
                    int firstIndex = int.Parse(commandInfo[1]);
                    int secondIndex = int.Parse(commandInfo[1]);
                    data.Swap(firstIndex, secondIndex);
                    break;
                case "greater":
                    string comparingEl = commandInfo[1];
                    Console.WriteLine(data.CounterGreaterThan(comparingEl));
                    break;
                case "max":
                    Console.WriteLine(data.Max());
                    break;
                case "min":
                    Console.WriteLine(data.Min());
                    break;
                case "print":
                    data.Container
                        .OrderBy(c => c)
                        .ToList()
                        .ForEach(Console.WriteLine);
                    break;
            }
        }
    }
}