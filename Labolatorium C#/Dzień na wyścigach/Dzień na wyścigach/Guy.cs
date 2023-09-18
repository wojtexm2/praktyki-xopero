using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        public bool PlaceBet(int ammount)
        {
            if (ammount <= Cash) {
                return true;
            }
            else
            {
                MessageBox.Show("Nie można zawrzeć zakładu!", "Nieudany zakład");
                return false;
            }
        }
        public void Collect(int Winner)
        {
            //aktualizacja etykiet i wypłata zakładu z pomocą MyBet
        }
    }
}
