using System.Collections.Generic;
using System.Linq;

namespace Poker
{
    public class PokerScorer
    {
        public bool Player1Won(string input)
        {
            List<Card> player1Hand;
            List<Card> player2Hand;

            var parser = new Parser();
            parser.StringToHands(input, out player1Hand, out player2Hand);

            return true;
        }
    }
}