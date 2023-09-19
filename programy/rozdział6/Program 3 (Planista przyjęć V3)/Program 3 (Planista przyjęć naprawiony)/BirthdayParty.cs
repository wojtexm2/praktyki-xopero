﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_3__Planista_przyjęć_naprawiony_
{
    internal class BirthdayParty : Party
    {
        public string CakeWriting { get; set; }
        public bool CakeWritingTooLong
        {
            get
            {
                if (CakeWriting.Length > MaxWritingLength()) return true;
                else return false;
            }
        }

        private int ActualLength
        {
            get
            {
                if (CakeWriting.Length > MaxWritingLength()) { return MaxWritingLength(); }
                else { return CakeWriting.Length; }
            }
        }
        private int CakeSize()
        {
            if (NumberOfPeople <= 4) { return 20; }
            else { return 40; }
        }
        private int MaxWritingLength()
        {
            if (CakeSize() == 8) { return 16; }
            else { return 40; }
        }
        override public decimal Cost
        {
            get
            {
                decimal totalCost = base.Cost;
                decimal cakeCost;
                if (CakeSize() == 20) cakeCost = 40M + ActualLength * .25M;
                else cakeCost = 75M + ActualLength * .25M;
                return totalCost + cakeCost;
            }
        }

        public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            CakeWriting = cakeWriting;
        }
    }
}
