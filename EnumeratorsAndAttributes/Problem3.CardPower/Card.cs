using System;

namespace Problem3.CardPower
{
    public class Card : IComparable<Card>
    {
        public Card(CardRank rank, CardSuit suit)
        {
            this.Rank = rank;
            this.Suit = suit;
        }

        public CardRank Rank { get; private set; }

        public CardSuit Suit { get; private set; }

        public int CompareTo(Card other)
        {
            return this.Power().CompareTo(other.Power());
        }

        public override string ToString()
        {
            return $"Card name: {Rank} of {Suit}; Card power: {Power()}";
        }

        public int Power()
        {
            var rankValue = (int)this.Rank;
            var suitValue = (int)this.Suit;
            return rankValue + suitValue;
        }

       
    }
}