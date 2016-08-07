using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem6.StrategyPattern
{
    class Startup
    {
        static void Main()
        {
            SortedSet<Person> nameSorter = new SortedSet<Person>(new NameComparator());
            SortedSet<Person> ageSorter = new SortedSet<Person>(new AgeComparator());

            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                string[] personInfo = Console.ReadLine().Split();
                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);
                Person person = new Person(name, age);
                nameSorter.Add(person);
                ageSorter.Add(person);
            }

            nameSorter.ToList().ForEach(Console.WriteLine);
            ageSorter.ToList().ForEach(Console.WriteLine);
        }
    }


    public class NameComparator : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            int result = x.Name.Length.CompareTo(y.Name.Length);
            if (result == 0)
            {
                result = String.Compare(x.Name[0].ToString(), y.Name[0].ToString(), false);
            }
            return result;
        }
    }

    public class AgeComparator : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.Age.CompareTo(y.Age);
        }
    }
}
