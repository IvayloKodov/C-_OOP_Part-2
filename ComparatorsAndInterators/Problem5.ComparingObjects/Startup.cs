using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem5.ComparingObjects
{
    class Startup
    {
        static void Main()
        {
            var persons = new List<Person>();

            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] personInfo = input.Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);
                string personName = personInfo[0];
                int personAge = int.Parse(personInfo[1]);
                string personTown = personInfo[2];

                Person person = new Person(personName, personAge, personTown);
                persons.Add(person);
                input = Console.ReadLine();
            }
            int comparePersonIndex = int.Parse(Console.ReadLine()) - 1;

            if (comparePersonIndex < persons.Count)
            {
                int equalPersons = persons.Count(p => p.CompareTo(persons[comparePersonIndex])==0);
                if (equalPersons != 1)
                {
                    Console.WriteLine($"{equalPersons} {persons.Count - equalPersons} {persons.Count}");
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
        }
    }
}