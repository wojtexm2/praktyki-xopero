using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dzień_na_wyścigach
{
    internal class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;
        public RadioButton MyRadioButton;
        public Label MyLabel;

        public void ClearBet()
        {
            MyBet.Ammount = 0;
            MyLabel.Text = Name + " nie zawarł zakładu";
        }
        public bool PlaceBet()
        {
            throw new NotImplementedException();
            //places bet in MyBet and returns true if successful
        }
        public void Collect(int Winner)
        {
            //aktualizacja etykiet i wypłata zakładu z pomocą MyBet
        }
    }
}
