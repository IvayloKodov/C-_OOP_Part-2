using System;
using System.Linq;

namespace Problem8.CusomListSorter
{
    public class CommandInterpreter
    {
        private static Data<string> data = new Data<string>();

        public static void Interpreter(string input)
        {
            string[] commandInfo = input.Split(new char[] {},StringSplitOptions.RemoveEmptyEntries);
            string command = commandInfo[0];

            switch (command)
            {
                case "Add":
                    string element = commandInfo[1];
                    data.Add(element);
                    break;
                case "Remove":
                    int index = int.Parse(commandInfo[1]);
                    data.Remove(index);
                    break;
                case "Contains":
                    string a = commandInfo[1];
                    Console.WriteLine("{0}",
                        data.Contains(a) ? "True" : "False");
                    break;
                case "Swap":
                    int firstIndex = int.Parse(commandInfo[1]);
                    int secondIndex = int.Parse(commandInfo[2]);
                    data.Swap(firstIndex, secondIndex);
                    break;
                case "Greater":
                    string comparingEl = commandInfo[1];
                    Console.WriteLine(data.CounterGreaterThan(comparingEl));
                    break;
                case "Max":
                    Console.WriteLine(data.Max());
                    break;
                case "Min":
                    Console.WriteLine(data.Min());
                    break;
                case "Print":
                    data.Container
                        .ForEach(Console.WriteLine);
                    break;
                case "Sort":
                     Sorter.Sort(data.Container);
                    break;
                default: 
                    break;
            }
        }
    }
}