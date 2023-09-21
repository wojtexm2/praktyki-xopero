using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_5__Dictionary___wprowadzenie_
{
    internal class JerseyNumber
    {
        public string Player { get; private set; }
        public int YearRetired { get; private set; }
        public JerseyNumber(string player, int yearRetired)
        {
            Player = player;
            YearRetired = yearRetired;
        }
    }
}
