using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckRacingGame
{
    public class Bettor
    {
        public int Amounts; //The amount of cash that was bet
        public int Trucks; //The number of the dog the bet is on
        public Punter Punter; //the guy who placed the bet

        public string GetTheDescription()
        {
            string description = "";
            description = this.Punter.ClientName + " bets " + this.Amounts + " dollars on Truck #" + Trucks;
            return description;
        }

        public int PayOut(int winner)
        {
            if (Trucks == winner)
            {
                return this.Amounts;
            }
            else
            {
                return -this.Amounts;
            }
        }
    }
}
