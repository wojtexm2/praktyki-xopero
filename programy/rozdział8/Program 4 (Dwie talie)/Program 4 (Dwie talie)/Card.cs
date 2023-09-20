using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_4__Dwie_talie_
{
    internal class Card
    {
        public Values Value;
        public Suits Suit;
        public Card(Suits suit, Values value)
        {
            Value = value;
            Suit = suit;
        }
    }
}
