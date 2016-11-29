using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public class HighestCardHand : Hand
    {
        public HighestCardHand(List<Card> cards) : base(cards,1)
        {
        }
    }
}
