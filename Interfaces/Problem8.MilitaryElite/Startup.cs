using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8.MilitaryElite
{
    public class Startup
    {
        public static void Main()
        {
            var allSoldiers = new List<Soldier>();
            var allPrivates = new List<Private>();
            string input = Console.ReadLine();
            while (input!="End")
            {
                string[] soldierInfo = input.Split();
                try
                {
                    CreateSoldier(soldierInfo,allSoldiers,allPrivates);
                }
                catch (Exception)
                {
                    
                }
                input = Console.ReadLine();
            }
            foreach (var soldier in allSoldiers)
            {
                Console.WriteLine(soldier);
            }
        }

        private static void CreateSoldier(string[] soldierInfo,List<Soldier> soldiers,List<Private> allPrivates )
        {
            string soldierType = soldierInfo[0];
            string id = soldierInfo[1];
            string firstName = soldierInfo[2];
            string lastName = soldierInfo[3];

            switch (soldierType.ToLower())
            {
                case "private":
                    decimal salary = decimal.Parse(soldierInfo[4]);
                    soldiers.Add(new Private(id, firstName, lastName, salary)); 
                    allPrivates.Add(new Private(id, firstName, lastName, salary));
                    break;
                case "leutenantgeneral":
                    HashSet<Private> leutenantPrivates = new HashSet<Private>();
                    for (int i = 5; i < soldierInfo.Length; i++)
                    {
                        var currentPrivate = allPrivates.FirstOrDefault(s => s.Id == soldierInfo[i]);
                        if (currentPrivate!=null)
                        {
                            leutenantPrivates.Add(currentPrivate);
                        }
                    }
                    soldiers.Add(new LeutenantGeneral(id, firstName, lastName, decimal.Parse(soldierInfo[4]), leutenantPrivates)); 
                    break;
                case "engineer":
                    HashSet<Repair> repairParts = new HashSet<Repair>();
                    for (int i = 6; i < soldierInfo.Length; i+=2)
                    {
                        repairParts.Add(new Repair(soldierInfo[i],int.Parse(soldierInfo[i+1])));
                    }
                    soldiers.Add(new Engineer(id, firstName, lastName, decimal.Parse(soldierInfo[4]), soldierInfo[5], repairParts));
                    break;
                case "commando":
                    HashSet<Mission> missions = new HashSet<Mission>();
                    for (int i = 6; i < soldierInfo.Length; i+=2)
                    {
                        try
                        {
                            missions.Add(new Mission(soldierInfo[i], soldierInfo[i + 1]));
                        }
                        catch (Exception)
                        {
                            
                        }
                    }
                    soldiers.Add(new Commando(id, firstName, lastName, decimal.Parse(soldierInfo[4]), soldierInfo[5], missions)); 
                    break;
                case "spy":
                    soldiers.Add(new Spy(firstName, lastName, id, int.Parse(soldierInfo[4]))); 
                    break;
            }
        }
    }
}