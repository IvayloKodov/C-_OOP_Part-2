using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5.BorderControl
{
    public class Startup
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            List<IId> allCitizens = new List<IId>();
            while (input != "End")
            {
                string[] citizenInfo = input.Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);

                if (citizenInfo.Length == 3)
                {
                    Citizen citizen = new Citizen(citizenInfo[0], int.Parse(citizenInfo[1]), citizenInfo[2]);
                    allCitizens.Add(citizen);
                }
                else if (citizenInfo.Length == 2)
                {
                    Robot robot = new Robot(citizenInfo[0], citizenInfo[1]);
                    allCitizens.Add(robot);
                }
                input = Console.ReadLine();
            }
            string checkPattern = Console.ReadLine();

            //Create soldier to check the citizens
            Soldier soldier = new Soldier(checkPattern);
            allCitizens.ForEach(c => soldier.CheckOfId(c));
            soldier.Violators.ForEach(v => Console.WriteLine(v.Id));
        }
    }
}
