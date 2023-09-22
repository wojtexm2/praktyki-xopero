using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Program_6__Idź_na_ryby____długie
{
    internal class Card : IComparable<Card>
    {
        private static string[] names0 = new string[]
            { "", "asów", "dwójek", "trójek", "czwórek", "piątek", "szóstek", "siódemek", "ósemek", "dziewiątek", "dziesiątek",
            "waletów", "dam", "króli" };
        private static string[] names1 = new string[]
            { "", "asa", "dwójkę", "trójkę", "czwórkę", "piątkę", "szóstkę", "siódemkę", "ósemkę", "dziewiątkę", "dziesiątkę", "waleta",
            "damę", "króla" };
        private static string[] names2AndMore = new string[]
            { "", "asy", "dwójki", "trójki", "czwórki", "piątki", "szóstki", "siódemki", "ósemki", "dziewiątki", "dziesiątki",
            "walety", "damy", "króle"};

        private static string[] suits = new string[] { "pik", "trefl", "karo", "kier" };
        private static string[] names = new string[] { "", "As", "Dwójka", "Trójka", "Czwórka", "Piątka", "Szóstka", "Siódemka",
        "Ósemka", "Dziewiątka", "Dziesiątka", "Walet", "Dama", "Król" };

        public static string Plural(Values value, int count)
        {
            if (count == 0) return names0[(int)value];
            if (count == 1) return names1[(int)value];
            return names2AndMore[(int)value];
        }

        public Values Value;
        public Suits Suit;

        public string Name
        {
            get
            {
                return names[(int)Value] + " " + suits[(int)Suit];
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
