using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem8.CardGame
{
    class Startup
    {
        static void Main()
        {
            var deck = CardDeckCreater.MakeCardDeck();
            var firstPlayer = new Player(Console.ReadLine());
            var secondPlayer = new Player(Console.ReadLine());

            //Fullfill first player cards
            ReadPlayerCards(firstPlayer, deck);
            ReadPlayerCards(secondPlayer, deck);
            List<Player> players = new List<Player>();
            players.Add(firstPlayer);
            players.Add(secondPlayer);

            var playerResult = players
                .OrderByDescending(p => p.PlayerCards.Max(c => c.Power())).First();
            var playerMaxCard = playerResult.PlayerCards.OrderByDescending(c => c.Power()).First();

            Console.WriteLine("{0} wins with {1} of {2}."
                , playerResult.Name, playerMaxCard.Rank, playerMaxCard.Suit);
        }

        private static void ReadPlayerCards(Player player, List<Card> deck)
        {
            while (player.NeedMoreCards())
            {
                var cardInfo = Console.ReadLine().Split();
                CheckAndAddCard(cardInfo, deck, player);
            }
        }

        private static void CheckAndAddCard(string[] cardInfo, List<Card> deck, Player player)
        {
            try
            {
                var cardRank = (CardRank)Enum.Parse(typeof(CardRank), cardInfo[0]);
                var cardSuit = (CardSuit)Enum.Parse(typeof(CardSuit), cardInfo[2]);
                Card card = new Card(cardRank, cardSuit);

                if (deck.Contains(card))
                {
                    player.AddCard(card);
                    deck.Remove(card);
                }
                else
                {
                    Console.WriteLine("Card is not in the deck.");
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("No such card exists.");
            }
        }
    }
}