using System;
using System.Collections.Generic;

namespace Problem8.CardGame
{
    public static class CardDeckCreater
    {
        public static List<Card> MakeCardDeck()
        {
            List<Card> cards = new List<Card>();

            var ranks = (CardRank[])Enum.GetValues(typeof(CardRank));
            var suits = (CardSuit[])Enum.GetValues(typeof(CardSuit));

            for (int i = 0; i < suits.Length; i++)
            {
                for (int j = 0; j < ranks.Length; j++)
                {
                    cards.Add(new Card(ranks[j],suits[i]));
                }
            }
            return cards;
        }
    }
}