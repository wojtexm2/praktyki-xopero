using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dzień_na_wyścigach
{
    internal class Bet
    {
        public int Ammount;
        public int Dog; //NUMER, nie obiekt
        public Guy Bettor;

        public string GetDescription()
        {
            return Bettor.Name + " postawił " + Ammount + " zł na psa numer " + Dog;
        }
        public int payOut(int winner)
        {
            if (Dog == winner)
            {
                return Ammount;
            }
            return -Ammount;
        }
    }
}
