using System;

namespace Problem1.CardSuit
{
    class Startup
    {
        static void Main()
        {
            string []input = Console.ReadLine().Split();


            var cardSuits = Enum.GetValues(typeof(CardSuit));

       
            Console.WriteLine("Card Suits:");
            foreach (var cardSuit in cardSuits)
            {
                Console.WriteLine($"Ordinal value: {(int)cardSuit}; Name value: {cardSuit}");
            }
        }
    }
}