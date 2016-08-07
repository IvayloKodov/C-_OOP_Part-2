using System;
using Problem5.KingGambit.Factories;

namespace Problem5.KingGambit
{
    public class Startup
    {
        public static void Main()
        {
            var king = new King(Console.ReadLine());
            SoldierFactory factory = new SoldierFactory(king);
            factory.CreateSoldiers();

            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] inputArgs = input.Split();
                switch (inputArgs[0])
                {
                    case "Attack":
                        king.RespondAttack();
                        break;
                    case "Kill":
                        factory.Soldiers[inputArgs[1]].Attacked();
                        break;
                }
                input = Console.ReadLine();
            }
        }
    }
}