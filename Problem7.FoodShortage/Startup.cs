using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem7.FoodShortage
{
    public class Startup
    {
        public static void Main()
        {
            int numberOfCitizens = int.Parse(Console.ReadLine());
            var allCitizens = new List<Citizen>();

            for (int i = 0; i < numberOfCitizens; i++)
            {
                string[] citizenInfo = Console.ReadLine().Split();
                string name = citizenInfo[0];
                int age = int.Parse(citizenInfo[1]);

                if (citizenInfo.Length==4)
                {
                    string id = citizenInfo[2];
                    string birthday = citizenInfo[3];
                    allCitizens.Add(new Person(name,age,id,birthday));
                }else if (citizenInfo.Length==3)
                {
                    string group = citizenInfo[2];
                    allCitizens.Add(new Rebel(name,age,group));
                }
            }

            string person = Console.ReadLine();
           
            while (person!="End")
            {
                var existPerson = allCitizens.Find(c => c.Name == person);
                if (existPerson!=null)
                {
                    existPerson.BuyFood();
                }
                person = Console.ReadLine();
            }
            Console.WriteLine(allCitizens.Sum(c=>c.Food));
        }
    }
}