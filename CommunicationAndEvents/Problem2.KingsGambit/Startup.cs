using System;

namespace Problem2.KingsGambit
{
    class Startup
    {
        static void Main()
        {
            Handler handler=new Handler();

            string kingName = Console.ReadLine();
            King king = new King(kingName);

            foreach (var soldier in Soldier.soldiers.Values)
            {
                king.kingAttacked += handler.OnKingAttack(soldier,EventArgs.Empty);
            }

            string[] guardsNames = Console.ReadLine().Split();
            foreach (var soldierName in guardsNames)
            {
                Soldier soldier = new RoyalGuard(soldierName);
            }

            string[] footNames = Console.ReadLine().Split();
            foreach (var footName in footNames)
            {
                Soldier soldier = new Footman(footName);
            }

            string[] command = Console.ReadLine().Split();

            while (command[0] != "End")
            {
                switch (command[0])
                {
                    case "Attack":
                        king.SomeoneAttackKing();
                        break;
                    case "Kill":
                        string soldierName = command[1];
                        Soldier.soldiers.Remove(soldierName);
                        break;
                }
                command = Console.ReadLine().Split();
            }
        }
    }
}
