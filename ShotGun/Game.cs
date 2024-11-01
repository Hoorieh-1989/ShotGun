using System;

namespace ShotGun
{
    public class Game
    {
        private Player player;     // The player instance
        private Player computer;   // The computer instance
        private Random random;     // Random number generator for computer actions

        // Constructor that initializes the game with player and computer instances
        public Game(Player player, Player computer)
        {
            this.player = player;        // Assigns the playert
            this.computer = computer;    // Assigns the computer 
            random = new Random();       // Initializs the random number generator
        }

        // Winner logic method
        public (string message, bool isGameOver) Winner()
        {
          
            if (player.Choice == "Load" && computer.Choice == "Load")
            {

                return ("Both players loaded a shot.", false);
            }
            // If player loads and computer blocks
            else if (player.Choice == "Load" && computer.Choice == "Block")
            {

                return ($"{player.Name} gets 1 shot, {computer.Name} blocked.", false);
            }
            // If both players block mot pc  Block
            else if (player.Choice == "Block" && computer.Choice == "Block")
            {
                return ("Both blocked¨,continue", false); // Both block, continue game
            }
            // If player shoots and computer blocks
            else if (player.Choice == "Shoot" && computer.Choice == "Block")
            {
                return ($"{player.Name} lost a shot.", false); // Player loses a shot to a block
            }
        
            else if (player.Choice == "Block" && computer.Choice == "Load")
            {
                return (" The player blocked, " +
                    $"and the computer loaded a shot", false); 
            }

            else if (player.Choice == "Block" && computer.Choice == "Shoot")
            {
                return ($"{computer.Name} lost a shot.", false);
            }
       
            else if (player.Choice == "Shoot" && computer.Choice == "Shoot")
            {
                return ("Both lost a shot", false); // Both players lose a shot
            }

            // If player shoots while computer loads
            else if (player.Choice == "Shoot" && computer.Choice == "Load")
            {
                ResetShots(); // Resets shots if player shoots and computer loads
                return ($"{player.Name} Wins the game!", true); // Player wins
            }
          
            else if (computer.Choice == "Shoot" && player.Choice == "Load")
            {
                ResetShots(); 
                return ($"{computer.Name} Wins the game!", true); // Computer wins
            }
            // If player uses shotgun
            else if (player.Choice == "Shotgun")
            {
                ResetShots(); // Resets shots when player uses Shotgun
                return ($"{player.Name} Wins the game with SHOTGUN :D !", true); // Player wins with Shotgun
            }
            // If computer uses shotgun
            else if (computer.Choice == "Shotgun")
            {
                ResetShots();
                return ($"{computer.Name} Wins the game with SHOTGUN :D !", true); // Computer wins with Shotgun
            }
            else
            {
                return ("Unexpected outcome", false); 
            }
        }

        // Resets the shot counts for both players to zero
        private void ResetShots()
        {
            player.Shot = 0;     // Set player's shots to 0
            computer.Shot = 0;   // Set computer's shots to 0
        }
    }
}
