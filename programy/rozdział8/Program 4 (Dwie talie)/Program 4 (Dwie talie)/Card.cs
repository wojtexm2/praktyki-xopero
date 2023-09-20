using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Program_4__Dwie_talie_
{
    internal class Card : IComparable<Card>
    {
        public Values Value;
        public Suits Suit;
        
        public string Name
        {
            get
            {
                return Value.ToString() + " of " + Suit.ToString();
            }
        }
        public Card(Suits suit, Values value)
        {
            this.Value = value;
            this.Suit = suit;
        }
        public int CompareTo(Card other)
        {
            if (Suit > other.Suit) return -1;
            if (Suit < other.Suit) return 1;
            if (Value > other.Value) return 1;
            if (Value < other.Value) return -1;
            return 0;
        }
    }
}
