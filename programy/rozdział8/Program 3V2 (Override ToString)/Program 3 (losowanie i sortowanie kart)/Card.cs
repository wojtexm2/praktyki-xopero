using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_3__losowanie_i_sortowanie_kart_
{
    internal class Card : IComparable<Card>
    {
        public Suits Suit;
        public Values Value;
        public string Name
        {
            get
            {
                return Suit.ToString() + " of " + Value.ToString();
            }
        }
        public Card(Suits suit, Values value)
        {
            Suit = suit;
            Value = value;
        }

        public int CompareTo(Card other)
        {
            if (this.Value < other.Value) return 1;
            if (this.Value > other.Value) return -1;
            if (this.Suit < other.Suit) return 1;
            if (this.Suit > other.Suit)return 1;
            return 0;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
