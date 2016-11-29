using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public class PairHand : Hand
    {
        

        public PairHand(List<Card> cards) : base(cards,2)
        {
            CardStrenght = 0;

            foreach (var card in cards)
            {
                if (CheckIfCardExist(card))
                {
                    if (CardStrenght < card.Value)
                    {
                        CardStrenght = card.Value;
                    }
                }
            }
        }

        private bool CheckIfCardExist(Card testCard)
        {
            foreach (var card in cards)
            {
                if (card.Value == testCard.Value && card.Suit != testCard.Suit)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
