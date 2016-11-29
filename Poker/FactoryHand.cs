using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    static class FactoryHand
    {
        public static Hand GetHandType(List<Card> cards ) {
            if (IsPair(cards))
            {
                return new PairHand(cards);
            }
            else {
                return new HighestCardHand(cards);
            }
        }

        private static bool IsPair(List<Card> cards)
        {
            return cards.Select(x => x.Value).Distinct().Count() == 4;
        }
    }
}
