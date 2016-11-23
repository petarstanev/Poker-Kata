using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public class Parser
    {
        public void StringToHands(string input, out List<Card> player1Hand, out List<Card> player2Hand)
        {
            player1Hand = new List<Card>();
            player2Hand = new List<Card>();

            var cards = input.Split(' ');
            var player1Cards = cards.Take(5).ToList();
            var player2Cards = cards.Skip(5).ToList();

            foreach (var item in player1Cards)
            {
                player1Hand.Add(new Card(item));
            }

            foreach (var item in player2Cards)
            {
                player2Hand.Add(new Card(item));
            }
        }

        private bool IsPair(List<Card> cards)
        {
            return cards.Select(x => x.Value).Distinct().Count() == 4;
        }
    }
}
