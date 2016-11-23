using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public abstract class Hand 
    {
        public List<Hand> cards;

        public int handStrenght{ get; set; }
        public int cardStrenght { get; set; }
        public int suitStrenght { get; set; }

        public List<Card> Cards { get; set; }

        public void CalclulateStrenght()
        {
            throw new NotImplementedException();
        }

        public Hand(List<Hand> cards) {
            this.cards = cards;
        }
    }
}
