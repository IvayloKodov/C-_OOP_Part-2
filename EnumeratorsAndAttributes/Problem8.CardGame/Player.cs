using System.Collections.Generic;

namespace Problem8.CardGame
{
    public class Player
    {
        private string name;
        private readonly List<Card> playerCards;

        public Player(string name)
        {
            this.Name = name;
            this.playerCards = new List<Card>();
        }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public IEnumerable<Card> PlayerCards => this.playerCards;

        public void AddCard(Card card)
        {
            this.playerCards.Add(card);
        }

        public bool NeedMoreCards()
        {
            if (this.playerCards.Count<5)
            {
                return true;
            }
            return false;
        }
    }
}