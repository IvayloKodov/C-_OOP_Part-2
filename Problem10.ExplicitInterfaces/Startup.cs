using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem10.ExplicitInterfaces
{
    class Startup
    {
        static void Main()
        {
            string input = Console.ReadLine();
            while (input!="End")
            {
                string[] personInfo = input.Split(new char[] {}, StringSplitOptions.RemoveEmptyEntries);
                string name = personInfo[0];
                string country = personInfo[1];
                int age = int.Parse(personInfo[2]);
                IPerson person = new Citizen(name,country,age);
                IResident resident = new Citizen(name,country,age);
                person.GetName();
                resident.GetName();

                input = Console.ReadLine();
            }
        }
    }
}