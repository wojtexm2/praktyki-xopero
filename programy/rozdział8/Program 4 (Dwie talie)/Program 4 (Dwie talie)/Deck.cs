﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_4__Dwie_talie_
{
    internal class Deck
    {
        private List<Card> cards;
        private Random random = new Random();

        public Deck()
        {
            cards = new List<Card>();
            for (int suit = 0; suit <= 3; suit++)
            for (int value = 1; value <= 13;  value++)
            cards.Add(new Card((Suits)suit, (Values)value));
        }
    }
}
