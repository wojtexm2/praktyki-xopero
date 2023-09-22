using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_3__losowanie_i_sortowanie_kart_
{
    internal class CardComparer : IComparer<Card>
    {
        public int Compare(Card x, Card y)
        {
            if (x.Value < y.Value) return -1;
            if (x.Value > y.Value) return 1;
            if (x.Suit < y.Suit) return -1;
            if (y.Suit > x.Suit) return 1;
            return 0;
        }
    }
}
