using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_1__Enum_wstęp_
{
    internal class Card
    {
        public Suits Suit { get; set; }
        public Values Value { get; set; }

        public Card(Suits suit, Values values)
        {
            this.Suit = suit;
            this.Value = values;
        }
        public string Name { get { return Value.ToString() + " of " + Suit.ToString(); } }
    }
}
