using System;

namespace Problem8.CardGame
{
    public class Card : IComparable<Card>
    {
        private CardRank rank;
        private CardSuit suit;

        public Card(CardRank rank, CardSuit suit)
        {
            this.Rank = rank;
            this.Suit = suit;
    }

        public CardRank Rank { get; private set; }

        public CardSuit Suit { get; private set; }
   

        public override bool Equals(object obj)
        {
            return this.CompareTo((Card)obj)==0;
        }

        public int CompareTo(Card other)
        {
            int rankComparer = this.Rank.CompareTo(other.Rank);
            if (rankComparer==0)
            {
                return this.Suit.CompareTo(other.Suit);
            }
            return rankComparer;
        }


        public int Power()
        {
            var rankValue = (int)this.Rank;
            var suitValue = (int)this.Suit;
            return rankValue + suitValue;
        }
    }
}