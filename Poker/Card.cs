using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public class Card
    {
        public Card(string input)
        {
            ApplyValue(input[0]);
            ApplySuit(input[1]);
        }

        public Suit Suit { get; set; }
        public int Value { get; set; }

        private void ApplySuit(char suitChar)
        {
            switch (suitChar)
            {
                case 'H':
                    Suit = Suit.Hearts;
                    break;
                case 'D':
                    Suit = Suit.Diamonds;
                    break;
                case 'S':
                    Suit = Suit.Spades;
                    break;
                case 'C':
                    Suit = Suit.Clubs;
                    break;
            }
        }

        private void ApplyValue(char valueChar)
        {
            int tempValue;
            var success = int.TryParse(valueChar.ToString(), out tempValue);

            if (success)
            {
                Value = tempValue;
            }
            else
            {
                switch (valueChar)
                {
                    case 'A':
                        Value = 14;
                        break;
                    case 'K':
                        Value = 13;
                        break;
                    case 'Q':
                        Value = 12;
                        break;
                    case 'J':
                        Value = 11;
                        break;
                    case 'T':
                        Value = 10;
                        break;
                }
            }
        }
    }
}
