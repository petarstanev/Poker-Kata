using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace Poker
{
    public class PokerScorer
    {
        private Hand player1HandResult;
        private Hand player2HandResult;

        public bool Player1Won(string input)
        {
            List<Card> player1Hand;
            List<Card> player2Hand;

            var parser = new Parser();
            parser.StringToHands(input, out player1Hand, out player2Hand);

            player1HandResult = FactoryHand.GetHandType(player1Hand);
            player2HandResult = FactoryHand.GetHandType(player2Hand);


            if(player1HandResult.HandStrenght > player2HandResult.HandStrenght) { 
                return true;
            }

            if (player1HandResult.HandStrenght == player2HandResult.HandStrenght)
            {
                if (CheckHandStrenght())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            return false;
        }

        private bool CheckHandStrenght()
        {
            if (player1HandResult.CardStrenght> player2HandResult.CardStrenght)
            {
                return true;
            }
            return false;
        }

    }
}