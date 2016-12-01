using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public abstract class Hand 
    {
        public List<Card> cards;

        public int HandStrenght{ get; set; }
        public int CardStrenght { get; set; }
        public int SuitStrenght { get; set; }

        public List<Card> Cards { get; set; }

        public void CalclulateStrenght()
        {
            throw new NotImplementedException();
        }

        protected Hand(List<Card> cards,int  handStasdsrenght) {
            this.cards = cards;
            this.HandStrenght = handStrenght;
        }

        public Hand(List<Card> cards)
        {
            this.cards = cards;
        }
    }
}
