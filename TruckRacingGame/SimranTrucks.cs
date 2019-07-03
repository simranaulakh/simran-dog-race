using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TruckRacingGame
{
    public partial class SimranTrucks : Form
    {
        Truck[] TruckArray = new Truck[4]; // creates one array of 4 Trucks objects 
        Punter[] PuntersArray = new Punter[3]; // creates one array of 3 client objects
        Random RandomNumbers = new Random();
        public SimranTrucks()
        {
            InitializeComponent();
            RaceTrackSetting();
        }
        private void RaceTrackSetting()//this funtion is for setting the race track
        {
            joe.Checked = true;
            // initialize minimum bet label
            minimumBetLabel.Text = "Minimum Bet : " + numericUpDownNumber.Minimum.ToString() + " dollars";

            // initialize all 4 elements of the TruckArray
            TruckArray[0] = new Truck()
            {
                TruckPictureBox = truck1,
                TruckStartingPosition = truck1.Left,
                TruckTrackLength = truckTrack.Width - truck1.Width,
                RandomNumber = RandomNumbers
            };

            TruckArray[1] = new Truck()
            {
                TruckPictureBox = truck2,
                TruckStartingPosition = truck2.Left,
                TruckTrackLength = truckTrack.Width - truck2.Width,
                RandomNumber = RandomNumbers
            };

            TruckArray[2] = new Truck()
            {
                TruckPictureBox = truck3,
                TruckStartingPosition = truck3.Left,
                TruckTrackLength = truckTrack.Width - truck3.Width,
                RandomNumber = RandomNumbers
            };

            TruckArray[3] = new Truck()
            {
                TruckPictureBox = truck4,
                TruckStartingPosition = truck4.Left,
                TruckTrackLength = truckTrack.Width - truck4.Width,
                RandomNumber = RandomNumbers
            };

            //initialize all 3 elements of the GuysArray
            PuntersArray[0] = new Punter()
            {
                ClientName = "Joe",
                TruckBet = null,
                Cashes = 50,
                MyRadioButton = joe,
                MyLabel = joeBetLabel
            };

            PuntersArray[1] = new Punter()
            {
                ClientName = "Bob",
                TruckBet = null,
                Cashes = 75,
                MyRadioButton = bobRadioButton,
                MyLabel = bobBetLabel
            };

            PuntersArray[2] = new Punter()
            {
                ClientName = "Al",
                TruckBet = null,
                Cashes = 45,
                MyRadioButton = alRadioButton,
                MyLabel = alBetLabel
            };

            for (int i = 0; i <= 2; i++)
            {
                PuntersArray[i].UpdateLabels();
                PuntersArray[i].TruckBet = new Bettor();
            }
        }

        private void raceButton_Click(object sender, EventArgs e)
        {
            //Trucks take starting position
            TruckArray[0].TrucksStartingPosition();
            TruckArray[1].TrucksStartingPosition();
            TruckArray[2].TrucksStartingPosition();
            TruckArray[3].TrucksStartingPosition();

            //disable race button till the end of the race
            bettingParlor.Enabled = false;

            //start timer
            RaceTimer.Start();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {

        }

        private void RaceTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i <= 3; i++)
            {
                if (TruckArray[i].TruckRace())
                {
                    RaceTimer.Stop();
                    bettingParlor.Enabled = true;
                    i++;
                    MessageBox.Show("Truck " + i + " won the race");
                    for (int j = 0; j <= 2; j++)
                    {
                        PuntersArray[j].Collect(i);
                        PuntersArray[j].ClearTheBet();
                    }

                    foreach (Truck Truck in TruckArray)
                    {
                        Truck.TrucksStartingPosition();
                    }
                    break;
                }

            }
        }

        private void Bets_Click(object sender, EventArgs e)
        {
            if (joe.Checked)
            {
                if (PuntersArray[0].PlaceBet((int)numericUpDownForBet.Value, (int)numericUpDownNumber.Value))
                {
                    joeBetLabel.Text = PuntersArray[0].TruckBet.GetTheDescription();
                }
            }
            else if (bobRadioButton.Checked)
            {
                if (PuntersArray[1].PlaceBet((int)numericUpDownForBet.Value, (int)numericUpDownNumber.Value))
                {
                    bobBetLabel.Text = PuntersArray[1].TruckBet.GetTheDescription();
                }
            }
            else if (alRadioButton.Checked)
            {
                if (PuntersArray[2].PlaceBet((int)numericUpDownForBet.Value, (int)numericUpDownNumber.Value))
                {
                    alBetLabel.Text = PuntersArray[2].TruckBet.GetTheDescription();
                }
            }
        }
    }
}
