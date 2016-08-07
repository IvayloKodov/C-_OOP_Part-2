using System;

namespace Problem5.KingGambit.Soldiers
{
    public class RoyalGuard : Soldier
    {
        private const int Lives = 3;
        public RoyalGuard(string name) : base(name)
        {
            base.lives = Lives;
        }

        public override void SoldierReplique(object sender, EventArgs e)
        {
            Console.WriteLine($"Royal Guard {this.name} is defending!");
        }
    }
}