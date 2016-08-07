using System;

namespace Problem2.KingsGambit
{
    public class RoyalGuard :Soldier
    {
        public RoyalGuard(string name) : base(name)
        {
        }

        public override void ReactionOnAttack()
        {
            Console.WriteLine($"Royal Guard {this.Name} is defending!");
        }
    }
}