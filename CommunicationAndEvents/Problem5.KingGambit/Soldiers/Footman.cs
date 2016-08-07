using System;

namespace Problem5.KingGambit.Soldiers
{
    public class Footman :Soldier
    {
        private const int Lives = 2;
        public Footman(string name) : base(name)
        {
            base.lives = Lives;
        }

        public override void SoldierReplique(object sender, EventArgs e)
        {
            Console.WriteLine($"Footman {this.name} is panicking!");
        }
    }
}