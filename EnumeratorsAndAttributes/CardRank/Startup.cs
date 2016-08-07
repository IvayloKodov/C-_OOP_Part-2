using System;

namespace CardRank
{
    class Startup
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();

            var cardRanks = Enum.GetValues(typeof(CardRank));


            Console.WriteLine("Card Ranks:");
            foreach (var cardRank in cardRanks)
            {
                Console.WriteLine($"Ordinal value: {(int)cardRank}; Name value: {cardRank}");
            }
        }
    }
}
