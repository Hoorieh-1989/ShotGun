using Microsoft.VisualBasic.Devices;
using System;

namespace ShotGun
{
    public class Player
    {

        public string Name { get; set; }
        public int Shot { get; set; }
        public string Choice { get; set; }

        // Konstruktor
        public Player(int shots, string name, string choice)
        {
            Shot = shots;
            Name = name;
            Choice = choice;
        }


        public void Load()
        {
            Choice = "Load";
            Shot++;
        }

        public void Shoot()
        {
            if (Shot > 0)
            {
                Choice = "Shoot";
                Shot--;
            }
            else
            {
                Choice = "0";
            }
        }


        public void Block()
        {
            Choice = "Block";
        }

        public void Shotgun()
        {
            if (Shot >= 3)
            {
                Choice = "Shotgun";
                Shot -= 3; // Use 3 shots for Shotgun
            }
        }

    }
}