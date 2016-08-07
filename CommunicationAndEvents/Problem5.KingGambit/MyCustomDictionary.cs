using System;
using System.Collections.Generic;
using Problem5.KingGambit.Soldiers;

namespace Problem5.KingGambit
{
    public class MyCustomDictionary : Dictionary<string, Soldier>
    {
        private King king;
        public MyCustomDictionary(King king)
        {
            this.king = king;
        }

        public void KillSoldier(object sender, EventArgs e)
        {
            var soldier = sender as Soldier;
            if (soldier != null)
            {
                king.RespondToTheAttack -= soldier.SoldierReplique;
                this.Remove(soldier.Name);
            }
        }
    }
}