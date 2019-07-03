using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TruckRacingGame
{
    public class Punter
    {
        public string ClientName; //the client name who will bet
        public Bettor TruckBet; //an istance of Bettor that has his bet
        public int Cashes; //how much cash he has

        //punter's control on the form

        public RadioButton MyRadioButton;
        public Label MyLabel;

        public void UpdateLabels()
        {
            MyRadioButton.Text = ClientName + " has " + Cashes + " dollars";
            MyLabel.Text = ClientName + " hasn't place a bet";

            if (Cashes == 0)//Code When bettor has no money to bet then it gets destroy
            {
                MyLabel.Text = String.Format("BUSTED");
                MyLabel.ForeColor = System.Drawing.Color.Red;
                MyRadioButton.Enabled = false;
            }

        }

        public void ClearTheBet()
        {
            TruckBet.Amounts = 0;
            TruckBet.Trucks = 0;
            TruckBet.Punter = this;
        }

        public bool PlaceBet(int BetAmount, int TruckToWin)
        {
            if (Cashes >= BetAmount)
            {
                TruckBet.Amounts = BetAmount;
                TruckBet.Trucks = TruckToWin;
                TruckBet.Punter = this;
                return true;
            }
            else return false;
        }

        public void Collect(int winner)
        {
            Cashes += TruckBet.PayOut(winner);
            this.UpdateLabels();
        }
    }
}
