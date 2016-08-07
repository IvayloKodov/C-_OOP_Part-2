using System;

namespace Problem2.KingsGambit
{
    public class Handler
    {
        public void OnKingAttack(object sender, EventArgs args)
        {
            if ((sender as RoyalGuard) != null)
            {
                Console.WriteLine($"Royal Guard {((RoyalGuard)sender).Name} is defending!");
            }
            else
            {
                Console.WriteLine($"Footman {((Footman)sender).Name} is panicking!");
            }
        }
    }
}