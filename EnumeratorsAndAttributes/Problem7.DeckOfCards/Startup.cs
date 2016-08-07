using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7.DeckOfCards
{
    class Startup
    {
        static void Main()
        {
            string input = Console.ReadLine();

            var ranks = (CardRank[])Enum.GetValues(typeof(CardRank));
            var suits = (CardSuit[])Enum.GetValues(typeof(CardSuit));

            for (int i = 0; i < suits.Length; i++)
            {
                for (int j = 0; j < ranks.Length; j++)
                {
                     Console.WriteLine($"{ranks[j]} of {suits[i]}");
                }
            }
        }
    }
}