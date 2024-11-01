using System;

namespace ShotGun
{
    public class Computer : Player
    {
        private Random random = new Random(); // Random number generator for selecting actions

        // Constructor for the Computer class, initializes its properties using the base Player class constructor.
        public Computer(int shot, string name, string choice)
            : base(shot, name, choice) // Calls the constructor of the Player
        {
        }
        public void ComputerAction()
        {
            int choice = random.Next(0, 4); // Generates load , shoot , Block , Shotgun
         
            switch (choice)
            {
                case 0:
                    Load();
                    Choice = "Load"; 
                    break;
                case 1:
                    if (Shot > 0)
                    {
                        Shoot();
                        Choice = "Shoot"; 
                    }
                    else
                    {
                        ComputerAction(); // Retry if no shots
                    }
                    break;
                case 2:
                    Block();
                    Choice = "Block"; 
                    break;
                case 3:
                    if (Shot >= 3)
                    {
                        Shotgun(); // Uses a shotgun if 3 or more shots
                        Choice = "Shotgun";
                    
                     }
                      else
            {
                Choice = "Load"; // Fall back to Load if not enough shots for Shotgun
                Load();
            }
            break;
        }
    }
}
    }

