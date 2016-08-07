namespace Problem5.KingGambit.Factories
{
    using System;
    using Problem5.KingGambit.Soldiers;

    public class SoldierFactory
    {
        private MyCustomDictionary soldiers;
        private King king;

        public SoldierFactory(King king)
        {
            this.king = king;
            this.soldiers = new MyCustomDictionary(king);
        }

        public MyCustomDictionary Soldiers
        {
            get { return this.soldiers; }
        }

        public void CreateSoldiers()
        {
            var royalGuards = Console.ReadLine().Split();
            foreach (var royalGuard in royalGuards)
            {
                var soldier = new RoyalGuard(royalGuard);
                soldier.Died += this.soldiers.KillSoldier;
                king.RespondToTheAttack += soldier.SoldierReplique;
                soldiers[royalGuard] = soldier;
            }

            var footMans = Console.ReadLine().Split();
            foreach (var footMan in footMans)
            {
                var soldier = new Footman(footMan);
                soldier.Died += this.soldiers.KillSoldier;
                king.RespondToTheAttack += soldier.SoldierReplique;
                soldiers[footMan] = soldier;
            }
        }
    }
}