using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3.CardPower
{
    class Startup
    {
        static void Main()
        {
            var firstCardRank = (CardRank)Enum.Parse(typeof(CardRank), Console.ReadLine());
            var firstCardSuit = (CardSuit)Enum.Parse(typeof(CardSuit), Console.ReadLine());
            Card firstCard = new Card(firstCardRank, firstCardSuit);

            var secondCardRank = (CardRank)Enum.Parse(typeof(CardRank), Console.ReadLine());
            var secondCardSuit = (CardSuit)Enum.Parse(typeof(CardSuit), Console.ReadLine());
            Card secondCard = new Card(secondCardRank, secondCardSuit);

            Console.WriteLine("{0}", firstCard.CompareTo(secondCard)==1? firstCard : secondCard);
        }
    }
}