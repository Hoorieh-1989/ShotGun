using System;

namespace ShotGun
{
   
    public class Computer : Player
    {
        private Random random = new Random(); // Random number generator for selecting actions

        // Constructor for the Computer class, initializes its properties using the base Player class constructor.
        public Computer(int shot, string name, string choice)
            : base(shot, name, choice) //base is used to //the instance are made for computer
                                       // call the constructor of the Player
        {
        }

        // This method determines the computer's action based on a random choice.
        public void ComputerAction()
        {
            // Generates a random number between 0 and 3 to decide the computer's action
            int choice = random.Next(0, 3); // Generates numbers 0, 1, 2, or 3

            switch (choice)
            {
                case 0:
                    Load(); // Computer chooses to load a shot
                    Choice = "Load"; // Updates the computer's choice
                    break;
                case 1:
                    if (Shot > 0)
                    {
                        Shoot(); // Computer chooses to shoot if it has shots available
                        Choice = "Shoot"; // Updates the computer's choice
                    }
                    else
                    {
                        ComputerAction(); // If no shots available, select a new action
                    }
                    break;
                case 2:
                    Block(); // Computer chooses to block
                    Choice = "Block"; // Updates the computer's choice
                    break;
                case 3:
                    // Computer chooses to use a shotgun if it has at least 2 shots
                    if (Shot >= 2)
                    {
                        Shotgun(); // Uses a shotgun
                        Choice = "Shotgun"; // Updates the computer's choice
                    }
                    else
                    {
                        ComputerAction(); // If not enough shots, select a new action
                    }
                    break;
            }
        }
    }
}
