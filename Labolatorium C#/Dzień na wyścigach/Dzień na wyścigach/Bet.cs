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
            throw new NotImplementedException();
            //Janek postawił 8 zł na psa numer 4
        }
        public int payOut(int winner)
        {
            throw new NotImplementedException();
            //rozumiem że int winner to numer psa który wygrał? Jeżeli == zwracam ammount, a jak != to -ammount
        }
    }
}
