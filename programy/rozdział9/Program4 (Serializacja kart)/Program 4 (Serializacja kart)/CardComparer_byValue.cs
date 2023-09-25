using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_4__Serializacja_kart_
{
    [Serializable]
    internal class CardComparer_byValue: IComparer<Card>
    {
        public int Compare(Card x, Card y)
        {
            if (x.Value > y.Value) return 1;
            if (y.Value < x.Value) return -1;
            if (x.Suit > y.Suit) return -1;
            if (x.Suit < y.Suit) return 1;
            return 0;
        }
    }
}
