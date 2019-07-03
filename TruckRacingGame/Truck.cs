using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TruckRacingGame
{
    public class Truck
    {
        public int TruckStartingPosition; // where my PictureBox Starts
        public int TruckTrackLength; //How long the truckracetrack is
        public PictureBox TruckPictureBox = null; //My PictureBox object
        public Random RandomNumber; //An integer random
        public int Locat = 0; //My Location on the track


        public void TrucksStartingPosition()
        {
            Locat = 0;
            TruckPictureBox.Top = TruckStartingPosition;
        }
        public bool TruckRace()
        {
            Locat += RandomNumber.Next(1, 5);
            TruckPictureBox.Top = Locat;
            if (TruckPictureBox.Top >= TruckTrackLength)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
    }
}
