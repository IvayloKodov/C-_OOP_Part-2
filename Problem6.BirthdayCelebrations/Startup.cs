using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem6.BirthdayCelebrations
{
    public class Startup
    {
        static void Main()
        {
            string input = Console.ReadLine();
            var allCitizens = new List<IBirthday>();

            while (input != "End")
            {
                string[] citizenInfo = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var currentCitizen = CreateCurrentCitizen(citizenInfo);
                if (currentCitizen != null)
                {
                    allCitizens.Add(currentCitizen);
                }
                input = Console.ReadLine();
            }
            string checkBirthday = Console.ReadLine();
            var sortedBirthdays = allCitizens.Where(c => c.Birthday.EndsWith(checkBirthday)).ToList();


            sortedBirthdays.ForEach(c => Console.WriteLine(c.Birthday));

        }

        private static IBirthday CreateCurrentCitizen(string[] citizenInfo)
        {
            string type = citizenInfo[0];
            switch (type)
            {
                case "Citizen":
                    return new Citizen(citizenInfo[1], int.Parse(citizenInfo[2]), citizenInfo[3], citizenInfo[4]);
                case "Pet":
                    return new Pet(citizenInfo[1], citizenInfo[2]);
                default:
                    return null;
            }
        }
    }
}
